using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormattingRulesLibrary;
using System.IO;
using iTextSharp;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Xml.Linq;
using System.Xml;
using Spire.Doc.Collections;
using System.Collections;
using Spire.Doc.Documents;

namespace FRC_System
{
    public partial class frmMain : Form
    {
        System.Data.DataTable infos;    // таблица с инф-ей о работах
        System.Data.DataTable styles;
        StyleDesc style;
        List<StyleDesc> styles_list;
        WordprocessingDocument document;
        Spire.Doc.Document docx_doc = new Spire.Doc.Document();
        GeneralInfo info;   // объект инфы
        int count;  // количество записей в таблице с работами
        int position;
        string doc_filepath;
        DocumentFormat.OpenXml.Wordprocessing.Paragraph firstParagraph;
        DocumentFormat.OpenXml.Wordprocessing.Paragraph firstParInSect;

        public frmMain()
        {
            InitializeComponent();
            info = new GeneralInfo();
            style = new StyleDesc();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadTable();
            moveFirstPB_Click(sender, e);
            if (doc_filepath == null)
            {
                btnClose.Enabled = false;
                btnCheck.Enabled = false;
            }
            else btnCheck.Enabled = true;
        }

        public void LoadTable()
        {
            info.LoadInfos(ref infos);
            count = infos.Rows.Count;
            position = infos.Rows.Count;
            curPosition.Text = position.ToString() + "/" + infos.Rows.Count.ToString();
            EnableControls();
        }

        public void MoveInDb(int newPosition)
        {
            info.work_id = (int)infos.Rows[newPosition]["work_id"]; // определение id работы
            info.FillGaps();
            style.LoadStyles(ref styles, info.work_id); // загрузка стилей
            styles_list = new List<StyleDesc>();
            txtDocTitle.Text = infos.Rows[newPosition]["work_title"].ToString();
            txtUpField.Text = infos.Rows[newPosition]["up_field"].ToString();
            txtBotField.Text = infos.Rows[newPosition]["bottom_field"].ToString();
            txtLeftField.Text = infos.Rows[newPosition]["left_field"].ToString();
            txtRightField.Text = infos.Rows[newPosition]["right_field"].ToString();

            txtOrient.Text = infos.Rows[newPosition]["orientation"].ToString();
            info.orientation = infos.Rows[newPosition]["orientation"].ToString().Trim();

            txtPapForm.Text = infos.Rows[newPosition]["paper_format"].ToString();
            info.paper_format_heigth = int.Parse(infos.Rows[newPosition]["heigth"].ToString());
            info.paper_format_width = int.Parse(infos.Rows[newPosition]["width"].ToString());
            info.paper_format_value = infos.Rows[newPosition]["paper_format"].ToString().Trim();

            if (infos.Rows[newPosition]["colont_id"].ToString() != "")
            {
                txtBotColont.Text = infos.Rows[newPosition]["bottom_size_colont"].ToString();
                txtUpColont.Text = infos.Rows[newPosition]["up_size_colont"].ToString();
                info.bottom_size_colont = double.Parse(infos.Rows[newPosition]["bottom_size_colont"].ToString());
                info.up_size_colont = double.Parse(infos.Rows[newPosition]["up_size_colont"].ToString());
            }
            else
            {
                txtBotColont.Text = "";
                txtUpColont.Text = "";
            }
            
            tbMax.Text = infos.Rows[newPosition]["max_vol_pages"].ToString();
            tbMin.Text = infos.Rows[newPosition]["min_vol_pages"].ToString();

            if (infos.Rows[newPosition]["numeration_id"].ToString() != "")
            {
                if (infos.Rows[newPosition]["font_id"].ToString() != "")
                    txtNumFont.Text = StyleDesc._Font(infos, newPosition, false, style, info);
                txtLocation.Text = infos.Rows[newPosition]["location"].ToString();
                info.num_location = infos.Rows[newPosition]["location"].ToString().TrimEnd();
            }
            else
            {
                txtNumFont.Text = "";
                txtLocation.Text = "";
            }

            txtStyles.Text = StyleDesc.Style(style, styles, styles_list, info);
        }


        public void EnableControls()
        {
            if (count == 0)
            {
                deletePB.Enabled = false;
                delGR.BringToFront();
            }
            else
            {
                deletePB.Enabled = true;
                deletePB.BringToFront();
            }
        }

        private DocumentFormat.OpenXml.Wordprocessing.Paragraph ReturnFirstInSect(Spire.Doc.Section sectPr)
        {
            Spire.Doc.Documents.Paragraph f_par = sectPr.Paragraphs[0];
            int index = IndexOfPar(f_par);
            DocumentFormat.OpenXml.Wordprocessing.Paragraph parXML = document.MainDocumentPart.Document.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList().ElementAt(index);
            return parXML;
        }
        // проверка полей
        private void MarginCheck(Spire.Doc.Section sectPr)
        {
            string comment = "Требуется изменить поля: ";
            var top = sectPr.PageSetup.Margins.Top;
            var bottom = sectPr.PageSetup.Margins.Bottom;
            var left = sectPr.PageSetup.Margins.Left;
            var right = sectPr.PageSetup.Margins.Right;
            double l_mar = Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(left) / 10), 2, MidpointRounding.AwayFromZero);
            double r_mar = Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(right) / 10), 2, MidpointRounding.AwayFromZero);
            double t_mar = Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(top) / 10), 2, MidpointRounding.AwayFromZero);
            double b_mar = Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(bottom) / 10), 2, MidpointRounding.AwayFromZero);
            if (l_mar != info.left_field)
                comment += "левое поле " + info.left_field.ToString() + "; ";
            if (r_mar != info.right_field)
                comment += "правое поле " + info.right_field.ToString() + "; ";
            if (t_mar != info.up_field)
                comment += "верхнее поле " + info.up_field.ToString() + "; ";
            if (b_mar != info.bot_field)
                comment += "нижнее поле " + info.bot_field.ToString() + ".";
                
            if (l_mar != info.left_field || r_mar != info.right_field || t_mar != info.up_field || b_mar != info.bot_field)
                AddCommentOnParagraph(ReturnFirstInSect(sectPr), comment);
        }

        // проверка кол-ва страниц
        private void PagesCheck()
        {
            string comment;
            if (docx_doc.Document.PageCount > info.max_volume)
            {
                comment = "Количество страниц не должно превышать " + info.max_volume.ToString() + ".";
                AddCommentOnParagraph(firstParagraph, comment);
            }
        }

        // проверка колонтитулов
        private void HeaderFooterCheck(Spire.Doc.Section s)
        {
            string comment = "Требуется изменить колонтитулы: ";
            double header_size = Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(s.PageSetup.HeaderDistance) / 10), 2, MidpointRounding.AwayFromZero);
            double footer_size = Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(s.PageSetup.FooterDistance) / 10), 2, MidpointRounding.AwayFromZero);
            if (header_size != info.up_size_colont)
                comment += "верхний колонтитул " + info.up_size_colont.ToString() + "; ";
            if (footer_size != info.bottom_size_colont)
                comment += "нижний колонтитул " + info.bottom_size_colont.ToString() + ".";
            if (header_size != info.up_size_colont || footer_size != info.bottom_size_colont)
                AddCommentOnParagraph(ReturnFirstInSect(s), comment);
        }
        private string _parCheck(Spire.Doc.Documents.Paragraph p)
        {
            string comment = " Измените колонтитулы: ";
            comment += "расположение " + info.num_location;
            comment += NumFontCheck(p);
            
            return comment;
        }
        private void NumPagesCheck(Spire.Doc.Section s)    // проверка нумерации страниц
        {
            string comment = "";
            if (s.HeadersFooters.Footer != null)
            {
               foreach (Spire.Doc.Documents.Paragraph p in s.HeadersFooters.Footer.Paragraphs)
               {
                   comment += _parCheck(p);
               }
            }
            if (s.HeadersFooters.Header != null)
            {
                foreach (Spire.Doc.Documents.Paragraph p in s.HeadersFooters.Header.Paragraphs)
                {
                    comment += _parCheck(p);
                }
            }
            if(comment!="")
                AddCommentOnParagraph(ReturnFirstInSect(s), comment);
        }
        private string NumFontCheck(Spire.Doc.Documents.Paragraph docXpar)    // проверка шрифта 
        {
            string com = "";
            // шрифт
            if (info.num_font_title != docXpar.BreakCharacterFormat.FontName)
                com += "; " + "название шрифта - " + info.num_font_title;
            if (info.num_size != docXpar.BreakCharacterFormat.FontSize)
                com += "; " + "размер шрифта - " + info.num_size.ToString();
            if (info.num_color == "черный")
            {
                if (docXpar.BreakCharacterFormat.TextColor.Name != "0")
                    com += "; " + "цвет - " + info.num_color;
            }
            else if (info.num_color == "красный")
            {
                if (docXpar.BreakCharacterFormat.TextColor.Name != "ffff0000")
                    com += "; " + "цвет - " + info.num_color;
            }
            else if (info.num_color == "серый")
            {
                if (docXpar.BreakCharacterFormat.TextColor.Name != "ffa5a5a5")
                    com += "; " + "цвет - " + info.num_color;
            }
            else if (info.num_color == "синий")
            {
                if (docXpar.BreakCharacterFormat.TextColor.Name != "ff2e74b5")
                    com += "; " + "цвет - " + info.num_color;
            }
            if (info.num_bold != docXpar.BreakCharacterFormat.Bold)
                com += "; " + "полужирный - " + info.num_bold.ToString();
            if (info.num_italic != docXpar.BreakCharacterFormat.Italic)
                com += "; " + "курсив - " + info.num_italic.ToString();

            bool line;
            if (docXpar.BreakCharacterFormat.UnderlineStyle != Spire.Doc.Documents.UnderlineStyle.None)
                line = true;
            else line = false;

            if (info.num_underlined != line)
                com += "; " + "подчеркнутый - " + info.num_underlined;
            return com;
        }
        public void PaperFormatOrientCheck(Spire.Doc.Section s)
        {
            string comment = "";
            
            var width = Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(s.PageSetup.PageSize.Width)), 0, MidpointRounding.AwayFromZero);
            var heigth = Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(s.PageSetup.PageSize.Height)), 0, MidpointRounding.AwayFromZero);
            
            if (info.orientation == "Книжная")
                if (s.PageSetup.Orientation != PageOrientation.Portrait)
                {
                    comment = "Необходимо изменить ориентацию страницы на книжную.";
                }
            if (info.orientation == "Альбомная")
                if (s.PageSetup.Orientation != PageOrientation.Landscape)
                {
                    comment = "Необходимо изменить ориентацию страницы на альбомную.";
                }
            if (width != info.paper_format_width || heigth != info.paper_format_heigth)
            {
                comment += "Необходимо выбрать формат бумаги " + info.paper_format_value;
                AddCommentOnParagraph(ReturnFirstInSect(s), comment);
            }
        }

        private List<Spire.Doc.Documents.Paragraph> FindParsWStyles(string st_name) // поиск абзацев для проверки
        {
            var pars = new List<Spire.Doc.Documents.Paragraph>();
            foreach (Spire.Doc.Section s in docx_doc.Sections)
            {
                ParagraphCollection spire_pars = s.Paragraphs;
                foreach (Spire.Doc.Documents.Paragraph p in spire_pars)
                {
                    if (p.StyleName == st_name)
                        pars.Add(p);
                }
            }
            return pars;
        }
        private int IndexOfPar(Spire.Doc.Documents.Paragraph p) // нахождение индекса абзаца для проверки
        {
            return ReturnNumberOfPars().IndexOf(p);
        }

        private List<Spire.Doc.Documents.Paragraph> ReturnNumberOfPars()    // возвращает все абзацы в тесте
        {
            List<Spire.Doc.Documents.Paragraph> spire_paragraphs = new List<Spire.Doc.Documents.Paragraph>();
            foreach (Spire.Doc.Section s in docx_doc.Sections)
                foreach (Spire.Doc.Documents.Paragraph par in s.Paragraphs)
                    spire_paragraphs.Add(par);
            return spire_paragraphs;
        }

        private void SpireStyleCheck(List<Spire.Doc.Documents.Paragraph> prsSt, StyleDesc st, string comment) // проверка стиля
        {
            int indexPar;
            DocumentFormat.OpenXml.Wordprocessing.Paragraph parXML;
            foreach (Spire.Doc.Documents.Paragraph p in prsSt)
            {
                if (p.Text != "")
                {
                    indexPar = IndexOfPar(p);
                    comment = CheckStyleProps(indexPar, st, p);
                    parXML = document.MainDocumentPart.Document.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().ToList().ElementAt(indexPar);
                    AddCommentOnParagraph(parXML, comment);
                }
            }
        }

        public void StylesCheck()   // проверка стиля и комментирование
        {
            string comment = "";
            List<Spire.Doc.Documents.Paragraph> spire_pars;
            foreach (StyleDesc st in styles_list)
            {
                if (st.style_title == "Заголовок 1")
                {
                    spire_pars = FindParsWStyles("Heading 1");
                    SpireStyleCheck(spire_pars, st, comment);
                }
                if (st.style_title == "Заголовок 2")
                {
                    spire_pars = FindParsWStyles("Heading 2");
                    SpireStyleCheck(spire_pars, st, comment);
                }
                if (st.style_title == "Заголовок 3")
                {
                    spire_pars = FindParsWStyles("Heading 3");
                    SpireStyleCheck(spire_pars, st, comment);
                }
                if (st.style_title == "Заголовок 3")
                {
                    spire_pars = FindParsWStyles("Heading 3");
                    SpireStyleCheck(spire_pars, st, comment);
                }
                if (st.style_title == "Заголовок 4")
                {
                    spire_pars = FindParsWStyles("Heading 4");
                    SpireStyleCheck(spire_pars, st, comment);
                }
                if (st.style_title == "Заголовок 5")
                {
                    spire_pars = FindParsWStyles("Heading 5");
                    SpireStyleCheck(spire_pars, st, comment);
                }
                if (st.style_title == "Подзаголовок")
                {
                    spire_pars = FindParsWStyles("Subtitle");
                    SpireStyleCheck(spire_pars, st, comment);
                }
                if (st.style_title == "Основной текст")
                {
                    spire_pars = FindParsWStyles("Normal");
                    SpireStyleCheck(spire_pars, st, comment);
                }
            }
        }

        public string CheckStyleProps(int index, StyleDesc styleForCheck, Spire.Doc.Documents.Paragraph docXpar) // проверка свойств стиля 
        {
            string style_com = "Измените настройки стиля '" + styleForCheck.style_title + "' следующим образом: ";

            // выравни
            if (styleForCheck.align == "по левому краю")
            {
                if (docXpar.Format.HorizontalAlignment != Spire.Doc.Documents.HorizontalAlignment.Left)
                    style_com += "Выравнивание по левому краю; ";
            }
            else if (styleForCheck.align == "по правому краю")
            {
                if (docXpar.Format.HorizontalAlignment != Spire.Doc.Documents.HorizontalAlignment.Right)
                    style_com += "выравнивание по правому краю; ";
            }
            else if (styleForCheck.align == "по центру")
            {
                if (docXpar.Format.HorizontalAlignment != Spire.Doc.Documents.HorizontalAlignment.Center)
                    style_com += "выравнивание по центру; ";
            }
            else if (styleForCheck.align == "по ширине")
            {
                if (docXpar.Format.HorizontalAlignment != Spire.Doc.Documents.HorizontalAlignment.Justify)
                    style_com += "выравнивание по ширине; ";
            }
            // отступы
            if (styleForCheck.indent_1st_string != Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(docXpar.Format.FirstLineIndent) / 10), 2, MidpointRounding.AwayFromZero))
                style_com += "отступ первой строки - " + styleForCheck.indent_1st_string.ToString();
            
            if (styleForCheck.right_indent != Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(docXpar.Format.RightIndent) / 10), 2, MidpointRounding.AwayFromZero))
                style_com += "; " + "отступ справа - " + styleForCheck.right_indent.ToString();
            
            if (styleForCheck.left_indent != Math.Round((iTextSharp.text.Utilities.PointsToMillimeters(docXpar.Format.LeftIndent) / 10), 2, MidpointRounding.AwayFromZero))
                style_com += "; " + "отступ слева - " + styleForCheck.left_indent.ToString();
            
            // интервалы
            if (styleForCheck.interval_before != docXpar.Format.BeforeSpacing)
                style_com += "; " +  "интервал перед абзацем - " + styleForCheck.interval_before.ToString();

            if (styleForCheck.interval_after != docXpar.Format.AfterSpacing)
                style_com += "; " + "интервал после абзаца - " + styleForCheck.interval_after.ToString();
            
            if (styleForCheck.interval_between != docXpar.Format.LineSpacing)
                style_com += "; " + "междустрочный интервал - " + styleForCheck.interval_between.ToString();
            style_com += FontCheck(styleForCheck, docXpar);
            
            return style_com;
        }

        private string FontCheck(StyleDesc styleForCheck, Spire.Doc.Documents.Paragraph docXpar)    // проверка шрифта 
        {
            string style_com = "";
            // шрифт
            if (styleForCheck.font_title != docXpar.BreakCharacterFormat.FontName)
                style_com += "; "+ "название шрифта - " + styleForCheck.font_title;
            if (styleForCheck.size != docXpar.BreakCharacterFormat.FontSize)
                style_com += "; " + "размер шрифта - " + styleForCheck.size.ToString();
            if (styleForCheck.color == "черный")
            {
                if (docXpar.BreakCharacterFormat.TextColor.Name != "0")
                    style_com += "; " + "цвет - " + styleForCheck.color;
            }
            else if (styleForCheck.color == "красный")
            {
                if (docXpar.BreakCharacterFormat.TextColor.Name != "ffff0000")
                    style_com += "; " + "цвет - " + styleForCheck.color;
            }
            else if (styleForCheck.color == "серый")
            {
                if (docXpar.BreakCharacterFormat.TextColor.Name != "ffa5a5a5")
                    style_com += "; " + "цвет - " + styleForCheck.color;
            }
            else if (styleForCheck.color == "синий")
            {
                if (docXpar.BreakCharacterFormat.TextColor.Name != "ff2e74b5")
                    style_com += "; " + "цвет - " + styleForCheck.color;
            }
            if (styleForCheck.bold != docXpar.BreakCharacterFormat.Bold)
                style_com += "; " + "полужирный - " + styleForCheck.bold.ToString();
            if (styleForCheck.italic != docXpar.BreakCharacterFormat.Italic)
                style_com += "; " + "курсив - " + styleForCheck.italic.ToString();

            bool line;
            if (docXpar.BreakCharacterFormat.UnderlineStyle != Spire.Doc.Documents.UnderlineStyle.None)
                line = true;
            else line = false;

            if (styleForCheck.underlined != line)
                style_com += "; " + "подчеркнутый - " + styleForCheck.underlined;
            return style_com;
        }

        private void btnUploadDoc_Click(object sender, EventArgs e) // обработка события загрузки файла документа для проверки
        {
            try
            {
                openFileDialog1.RestoreDirectory = true;
                openFileDialog1.Filter = "Word Documents " + " " + "(*.doc, *.docx)|*.doc;*.docx";
                openFileDialog1.FileName = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    doc_filepath = openFileDialog1.FileName;    // путь загружаемого файла
                    lbldoc.Text = Path.GetFileName(doc_filepath);   // вывод названия документа на экран

                    winWordControl1.LoadDocument(doc_filepath); // открытие документа в окне приложения
                    docx_doc.LoadFromFile(doc_filepath);    // загрузка документа Spire.Doc
                    btnCheck.Enabled = true;    // разблокировка кнопок
                    btnClose.Enabled = true;    // проверки и закрытия документа
                }
            }
            catch(Exception)
            { MessageBox.Show("Ошибка загрузки. Проверьте файл документа."); }
        }

        public void PerformChecking()   // выполнение проверки документа по всем праметрам
        {
            try
            {
                if (doc_filepath.Length > 0)
                {
                    if (ReturnNumberOfPars().Count > 100) { throw new Exception(); }
                    else
                    {
                        using (document = WordprocessingDocument.Open(openFileDialog1.FileName, true))  // документ  Open XML
                        {
                            firstParagraph =
                                document.MainDocumentPart.Document.Descendants<DocumentFormat.OpenXml.Wordprocessing.Paragraph>().First(); // определение первого абзаца текста

                            foreach (Spire.Doc.Section s in docx_doc.Sections)  // проход по всем абзацам документа
                            {
                                MarginCheck(s);  // проверка полей документа
                                PaperFormatOrientCheck(s);   // проверка формата бумаги и ориентации
                                HeaderFooterCheck(s);// проверка размеров колонтитулов
                                NumPagesCheck(s);// проверка нумерации страниц
                            }
                            PagesCheck();// проверка количества страниц
                            StylesCheck();// проверка стилей, используемых в документе
                        }
                    }
                }
            }
            catch(Exception)
            { MessageBox.Show("Количество абзацев не должно превышать 100!"); }
        }
        
        //Добавление комментария 
        public void AddCommentOnParagraph(DocumentFormat.OpenXml.Wordprocessing.Paragraph comPar, string comment)
        {
                DocumentFormat.OpenXml.Wordprocessing.Comments comments = null;
                string id = "0";

                // Verify that the document contains a 
                // WordProcessingCommentsPart part; if not, add a new one.
                if (document.MainDocumentPart.GetPartsCountOfType<WordprocessingCommentsPart>() > 0)
                {
                    comments =
                        document.MainDocumentPart.WordprocessingCommentsPart.Comments;
                    if (comments.HasChildren == true)
                    {
                        // Obtain an unused ID.
                        id = comments.Descendants<DocumentFormat.OpenXml.Wordprocessing.Comment>().Select(e => e.Id.Value).Max() + 1;
                    }
                }
                else
                {
                    // No WordprocessingCommentsPart part exists, so add one to the package.
                    WordprocessingCommentsPart commentPart = document.MainDocumentPart.AddNewPart<WordprocessingCommentsPart>();
                    commentPart.Comments = new DocumentFormat.OpenXml.Wordprocessing.Comments();
                    comments = commentPart.Comments;
                }

                // Compose a new Comment and add it to the Comments part.
                DocumentFormat.OpenXml.Wordprocessing.Paragraph p = new DocumentFormat.OpenXml.Wordprocessing.Paragraph(new DocumentFormat.OpenXml.Wordprocessing.Run(new Text(comment)));
                DocumentFormat.OpenXml.Wordprocessing.Comment cmt =
                    new DocumentFormat.OpenXml.Wordprocessing.Comment()
                    {
                        Id = id,
                        Author = "FRChecking System",
                        Date = DateTime.Now
                    };
                cmt.AppendChild(p);
                comments.AppendChild(cmt);
                comments.Save();

                // Specify the text range for the Comment. 
                // Insert the new CommentRangeStart before the first run of paragraph.
                comPar.InsertBefore(new CommentRangeStart() { Id = id }, comPar.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Run>());

                // Insert the new CommentRangeEnd after last run of paragraph.
                var cmtEnd = comPar.InsertAfter(new CommentRangeEnd() { Id = id }, comPar.Elements<DocumentFormat.OpenXml.Wordprocessing.Run>().Last());

                // Compose a run with CommentReference and insert it.
                comPar.InsertAfter(new DocumentFormat.OpenXml.Wordprocessing.Run(new CommentReference() { Id = id }), cmtEnd);
            
        }

        private void moveFirstPB_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                if (count > 1)
                {
                    LastNextEnabled(true);
                }
                FirstPrevEnabled(false);
                OneLeft();
                position = 1;
                MoveInDb(0);
                curPosition.Text = "1/" + count.ToString();
            }
        }

        private void movePrevPB_Click(object sender, EventArgs e)
        {
            LastNextEnabled(true);
            position--;
            if (position > 0)
            {
                MoveInDb(position - 1);
                curPosition.Text = position.ToString() + "/" + count.ToString();
            }
            else
                position = 1;
            if (position == 1)
                FirstPrevEnabled(false);
        }

        private void moveNextPB_Click(object sender, EventArgs e)
        {
            FirstPrevEnabled(true);
            position++;
            if (position <= count)
            {
                MoveInDb(position - 1);
                curPosition.Text = position.ToString() + "/" + count.ToString();
            }
            else
                position = count;
            if (position == count)
                LastNextEnabled(false);
        }

        private void moveLastPB_Click(object sender, EventArgs e)
        {
            FirstPrevEnabled(true);
            LastNextEnabled(false);
            OneLeft();
            position = count;
            MoveInDb(count - 1);
            curPosition.Text = count.ToString() + "/" + count.ToString();
        }

        private void FirstPrevEnabled(bool perem)
        {
            if (perem == true)
            {
                moveFirstPB.Enabled = true;
                movePrevPB.Enabled = true;
                moveFirstPB.BringToFront();
                movePrevPB.BringToFront();
            }
            else
            {
                moveFirstPB.Enabled = false;
                movePrevPB.Enabled = false;
                firstGR.BringToFront();
                prevGR.BringToFront();
            }
        }

        private void LastNextEnabled(bool perem)
        {
            if (perem == true)
            {
                moveLastPB.Enabled = true;
                moveNextPB.Enabled = true;
                moveLastPB.BringToFront();
                moveNextPB.BringToFront();
            }
            else
            {
                moveLastPB.Enabled = false;
                moveNextPB.Enabled = false;
                lastGR.BringToFront();
                nextGR.BringToFront();
            }
        }

        public void OneLeft()
        {
            if (count == 1 || count == 0)
            {
                LastNextEnabled(false);
                FirstPrevEnabled(false);
            }
        }

        private void deletePB_Click(object sender, EventArgs e)
        {
            info.DeleteInfo();
            LoadTable();
            moveFirstPB_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            info.FillGaps();
            frmAddEditInfo edit_info = new frmAddEditInfo(info);
             if (edit_info.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                info = edit_info._info;
                info.UpdateInfo();
                LoadTable();
                moveFirstPB_Click(sender, e);
            }
        }

        private void addPB_Click(object sender, EventArgs e)
        {
            frmAddEditInfo aei = new frmAddEditInfo();
            info.AddBlankInfo();
            aei.info_id = FormattingRulesLibrary.GeneralInfo.LastWork();
            if (aei.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                info = aei._info; // переменная получает значение из формы
                info.UpdateInfo();
                LoadTable();
                moveLastPB_Click(sender, e);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            PerformChecking();
            winWordControl1.CloseControl();
            winWordControl1.LoadDocument(doc_filepath);
        }

        private void KillWord()
        {
            // убиваем процесс
            System.Diagnostics.Process[] localByName = System.Diagnostics.Process.GetProcesses();
            foreach (System.Diagnostics.Process pr in localByName)
            {
                if (pr.ProcessName == "WINWORD")
                {
                    pr.Kill();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            winWordControl1.CloseControl();
            docx_doc.Close();
            btnCheck.Enabled = false;
            btnClose.Enabled = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            docx_doc.Close();
            KillWord();
        }

    }
}
