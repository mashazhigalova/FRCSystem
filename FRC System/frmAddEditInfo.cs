using FormattingRulesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace FRC_System
{
    public partial class frmAddEditInfo : Form
    {
        public GeneralInfo _info = new GeneralInfo();   // объект информации о работе
        public int info_id;
        Colontitul col = new Colontitul();

        Numeration numeration = new Numeration();   // нумерация
        Location loc = new Location();
        
        FormattingRulesLibrary.Font font = new FormattingRulesLibrary.Font();
        FontTitle f_title = new FontTitle();
        FormattingRulesLibrary.Color color = new FormattingRulesLibrary.Color();
        StyleDesc _style = new StyleDesc();

        DataTable dtOrientation; 
        DataTable dtPaperFormats;
        DataTable styles;

        public frmAddEditInfo()
        {
            InitializeComponent();
            FillChBoxes();
            info_id = _info.work_id;
            StyleDelEnable();
        }

        public frmAddEditInfo(GeneralInfo info)
        {
            InitializeComponent();
            FillChBoxes();
            info_id = info.work_id;
            _info = info;

            if (_info.numeration!=0)
                FillNum(info);
            FillColont(info);

            txtWorkName.Text = info.work_title; // заполнение данных о работе
            numBottom.Value = (decimal)info.bot_field;
            numUp.Value = (decimal)info.up_field;
            numRight.Value = (decimal)info.right_field;
            numLeft.Value = (decimal)info.left_field;
            tbMinVolume.Text = info.min_volume.ToString();
            tbMaxVolume.Text = info.max_volume.ToString();
            cbOrient.SelectedValue = info.orient;
            cbPaperFormat.SelectedValue = info.paper_format;

            _style.LoadStyles(ref styles, info.work_id); // загрузка стилей
            
            Style();
        }

        public string StyleString()
        {
            string style = "";
            for (int i = 0; i < styles.Rows.Count; i++)
            {
                if (styles.Rows[i]["style_id"] != null)
                {
                    style += "***" + styles.Rows[i]["style_title"].ToString().Trim() + "***";
                }
            }
            return style;
        }

        private void StyleDelEnable()
        {
            if (lbStyles.Items.Count > 0)
                btnDelStyle.Enabled = true;
            else btnDelStyle.Enabled = false;
        }
        public void Style()
        {
            lbStyles.DataSource = styles;
            string st = StyleString(); 
            lbStyles.DisplayMember = "style_title";
            lbStyles.ValueMember = "style_id";
            StyleDelEnable();
        }
        private void FillNum(GeneralInfo info)
        {
            numeration.numeration_id = info.numeration; // заполнение нумерации
            numeration.FillGaps();
            if (numeration.location != 0)
            {
                numeration.FillLocationGaps(ref loc);
                tbPlace.Text = loc.location.Trim();
            }
            else tbPlace.Text = "";

            font.font_id = numeration.num_font; // заполнение шрифтов
            if (font.font_id != 0)
            {
                font.FillFontGaps();
                chbCurs.Checked = font.italic;
                chbZh.Checked = font.bold;
                chPodch.Checked = font.underlined;
                tbSize.Text = font.size.ToString();
                font.FillFTitleGaps(ref f_title);
                tbFontName.Text = f_title.font_title;
                font.FillColorGaps(ref color);
                tbColor.Text = color.color;
            }
            else
            {
                chbCurs.Checked = false;
                chbZh.Checked = false;
                chPodch.Checked = false;
                tbSize.Text = "";
                tbFontName.Text = "";
                tbColor.Text = "";
            }
        }

        private void FillColont(GeneralInfo info)
        {
            if (info.colont != 0)
            {
                col.colont_id = info.colont;    // заполнение колонтитулов
                col.FillColontGaps();
                tbUpColont.Text = col.up_size.ToString();
                tbBotColont.Text = col.bot_size.ToString();
            }
        }

        private void FillChBoxes()
        {
            _info.LoadOrientation(ref dtOrientation);
            _info.LoadPFormats(ref dtPaperFormats);
            cbOrient.DataSource = dtOrientation;
            cbOrient.DisplayMember = "orientation";
            cbOrient.ValueMember = "orient_id";
            cbPaperFormat.DataSource = dtPaperFormats;
            cbPaperFormat.DisplayMember = "paper_format";
            cbPaperFormat.ValueMember = "paper_format_id";
        }

        private void tbMinVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            } 
        }

        private void tbMaxVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            } 
        }

        private void btnPaperFormat_Click(object sender, EventArgs e)
        {
            frmPaperFormat pf = new frmPaperFormat();
            if (pf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FillChBoxes();
                pf.Close();
            }
        }

        private void btAddColont_Click(object sender, EventArgs e)
        {
            frmColont fcol = new frmColont();
            if (fcol.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _info.colont = fcol.col_id;
                FillColont(_info);
                fcol.Close();
            }
        }

        private void btnAddNumer_Click(object sender, EventArgs e)
        {
            frmNumeration num = new frmNumeration();
            if (num.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _info.numeration = num.num_id;
                FillNum(_info);
                numeration = num.num;   // получение выбранного объекта нумерации
                num.Close();
                btnAddNumFont.Enabled = true;
                btnDeleteNum.Enabled = true;
            }
        }

        private void btnAddNumFont_Click(object sender, EventArgs e)
        {
            frmFont font_form = new frmFont();
            if (font_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                numeration.num_font = font_form.font_id;
                numeration.UpdateFontInNum();
                _info.numeration = numeration.numeration_id;
                FillNum(_info);
                font_form.Close();
            }
        }

        private void frmAddEditInfo_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(label11, "Обязательное поле");
            toolTip2.SetToolTip(lbStyles, "Щелкните дважды, чтобы получить информацию о стиле");
            WorkTitleCheck();
            if (numeration.numeration_id == 0)
            {
                btnAddNumFont.Enabled = false;
                btnDeleteNum.Enabled = false;
            }
        }

        public void PagVals()
        {
            int number_1;   // проверка на максимальное значение страниц
            if (!int.TryParse(tbMaxVolume.Text, out number_1))
            { _info.max_volume = number_1; }
            else _info.max_volume = int.Parse(tbMaxVolume.Text);

            int number_2;   // проверка на минимальное значение страниц
            if (!int.TryParse(tbMinVolume.Text, out number_2))
            { _info.min_volume = number_2; }
            else _info.min_volume = int.Parse(tbMinVolume.Text);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            PagVals();

            _info = new GeneralInfo(txtWorkName.Text, (int)cbOrient.SelectedValue, double.Parse(numUp.Value.ToString()), double.Parse(numBottom.Value.ToString()),
                    double.Parse(numLeft.Value.ToString()), double.Parse(numRight.Value.ToString()), _info.min_volume, _info.max_volume,
                        col.colont_id, numeration.numeration_id, (int)cbPaperFormat.SelectedValue);
                _info.work_id = info_id;
            
        }

        private void btnDeleteNum_Click(object sender, EventArgs e)
        {
            _info.numeration = 0;
            numeration = new Numeration();
            FillNum(_info);
            btnAddNumFont.Enabled = false;
            btnDeleteNum.Enabled = false;
        }

        private void btnAddStyle_Click(object sender, EventArgs e) // добавление стиля
        {
            string d = lbStyles.Items.ToString();
            try
            {
                frmStyle style_form = new frmStyle();
                if (style_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _style = style_form.style;
                    if (lbStyles.FindString(_style.style_title) != -1)
                    { throw new Exception(); }
                        if (_style.IsThereStyle(info_id) == false)
                        {
                            _style.InsertStyleInStyles(info_id);
                            _style.LoadStyles(ref styles, info_id); // загрузка стилей
                            Style();
                        }
                        else System.Windows.Forms.MessageBox.Show("Ошибка добавления!\nПопытка добавить уже существующий стиль.", "Добавление стиля");
                    style_form.Close();
                }
            }
            catch (Exception) { System.Windows.Forms.MessageBox.Show("Ошибка добавления!\nПопытка добавить стиль с тем же названием.", "Добавление стиля"); }
        }

        private void btnDelStyle_Click(object sender, EventArgs e)
        {
            if (lbStyles.SelectedIndex != -1)
            {
                _style.style_id = (int)lbStyles.SelectedValue;
                _style.DeleteStyleInStyles(info_id);
                _style.LoadStyles(ref styles, info_id); // загрузка стилей
                Style();
            }
        }

        private void frmAddEditInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtWorkName.Text.Trim() == "")
                _info.DeleteBlankInfo();
        }

        private void txtWorkName_KeyUp(object sender, KeyEventArgs e)
        {
            WorkTitleCheck();
        }

        private void WorkTitleCheck()
            {if (txtWorkName.Text.Trim() == "")
                btnOK.Enabled = false;
            else btnOK.Enabled = true;}

        private void lbStyles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbStyles.SelectedItem != null)
            {
                if (styles.Rows.Count > 0)
                    if (styles.Columns["style_id"] != null)
                        styles.PrimaryKey = new DataColumn[] { styles.Columns["style_id"] };
                DataTable newSts = styles.Clone();
                DataRow st  = styles.Rows.Find((int)lbStyles.SelectedValue);
                newSts.Rows.Add(st.ItemArray);
                frmStyleDetails frm = new frmStyleDetails();

                StyleDesc sty = new StyleDesc();
                List<StyleDesc> lis = new List<StyleDesc>();
                GeneralInfo ginfo = new GeneralInfo();
                frm.labStyle.Text = StyleDesc.Style(sty, newSts, lis, ginfo);
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    frm.Close();
                }
            }
        }

        private void tbMinVolume_KeyUp(object sender, KeyEventArgs e)
        {
            PagCheck();
        }

        private void tbMaxVolume_KeyUp(object sender, KeyEventArgs e)
        {
            PagCheck();
        }

        public void PagCheck()
        {
            PagVals();
            if (_info.min_volume > _info.max_volume)
            {
                btnOK.Enabled = false;
                labEx1.Visible = true;
                labEx2.Visible = true;
            }
            else
            {
                labEx1.Visible = false;
                labEx2.Visible = false;
                btnOK.Enabled = true;
            }
        }

    }
}
