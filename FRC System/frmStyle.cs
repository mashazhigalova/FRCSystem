using FormattingRulesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRC_System
{
    public partial class frmStyle : Form
    {
        DataTable styleDT = new DataTable();
        public StyleDesc style;
        FormattingRulesLibrary.Font font = new FormattingRulesLibrary.Font();
        FormattingRulesLibrary.Paragraph par = new FormattingRulesLibrary.Paragraph();
        BindingSource bs = new BindingSource();
        public int style_id;

        public frmStyle()
        {
            InitializeComponent();
            style = new StyleDesc();
            LoadStyle();
            bs.DataSource = styleDT;
            stBindingNavigator.BindingSource = bs;
            tbStTitle.DataBindings.Add(new Binding("Text", bs, "style_title"));
            tbSize.DataBindings.Add(new Binding("Text", bs, "size"));
            tbFTitle.DataBindings.Add(new Binding("Text", bs, "font_title"));
            tbColor.DataBindings.Add(new Binding("Text", bs, "color"));
            chbCurs.DataBindings.Add(new Binding("Checked", bs, "italic"));
            chbZh.DataBindings.Add(new Binding("Checked", bs, "bold"));
            chPodch.DataBindings.Add(new Binding("Checked", bs, "underlined"));

            tbAlign.DataBindings.Add(new Binding("Text", bs, "alignment"));
            tbRight.DataBindings.Add(new Binding("Text", bs, "right_indent"));
            tbLeft.DataBindings.Add(new Binding("Text", bs, "left_indent"));
            tbOtst.DataBindings.Add(new Binding("Text", bs, "indent_1st_string"));
            tbBefore.DataBindings.Add(new Binding("Text", bs, "interval_before"));
            tbAfter.DataBindings.Add(new Binding("Text", bs, "interval_after"));
            tbStrInt.DataBindings.Add(new Binding("Text", bs, "interval_between"));
        }

        private void InitStyle()
        {
            style.style_title = styleDT.Rows[bs.Position]["style_title"].ToString();
            style.font = (int)styleDT.Rows[bs.Position]["font_id"];
            style.style_title = styleDT.Rows[bs.Position]["style_title"].ToString();
            style.style_id = (int)styleDT.Rows[bs.Position]["style_id"];
            style.paragraph = (int)styleDT.Rows[bs.Position]["paragraph_id"];

            font.font_id = style.font;  // шрифт получает значение id шрифта в стиле
            font.FillFontGaps();
            par.paragraph_id = style.paragraph;
            par.FillPar();
        }

        private void OneItemCheck() // проверка на присутствие только одного элемента
        {
            if (styleDT.Rows.Count == 1)
                bindingNavigatorDeleteItem.Enabled = false;
            else
                bindingNavigatorDeleteItem.Enabled = true;
        }

        private void LoadStyle()    // загрузка стиля
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");

            SqlCommand comSt = con.CreateCommand();
            comSt.CommandText = @"SELECT        StyleDesc.style_id, StyleDesc.style_title, Paragraph.left_indent, Paragraph.right_indent, Paragraph.indent_1st_string, Paragraph.interval_before, Paragraph.interval_after, 
                         Paragraph.interval_between, Paragraph.paragraph_id, FontTitle.font_title, FontTitle.font_title_id, Font.font_id, Font.italic, Font.underlined, Font.bold, Font.size, Color.color_id, Color.color, Alignment.align_id, 
                         Alignment.alignment
                         FROM            Paragraph INNER JOIN
                         Alignment ON Paragraph.alignment = Alignment.align_id INNER JOIN
                         StyleDesc ON Paragraph.paragraph_id = StyleDesc.paragraph INNER JOIN
                         Font INNER JOIN
                         Color ON Font.color = Color.color_id INNER JOIN
                         FontTitle ON Font.font_title = FontTitle.font_title_id ON StyleDesc.font = Font.font_id";
            SqlDataAdapter adaptFNum = new SqlDataAdapter(comSt);
            styleDT = new DataTable();
            try
            {
                con.Open();
                adaptFNum.Fill(styleDT);
            }
            finally
            {
                con.Close();
            }
        }

        private void frmStyle_Load(object sender, EventArgs e)
        {
            InitStyle();
            OneItemCheck();
        }

        private void stBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            InitStyle();
            OneItemCheck();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            InitStyle();
            style_id = style.style_id;
        }

        private void bindingNavigatorEditFontItem_Click(object sender, EventArgs e)
        {
            InitStyle();
            frmEditFont e_font = new frmEditFont(font);
            if (e_font.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                font = e_font._font; // переменная получает значение из формы
                font.CheckFont();
                if (font.font_id == 0)
                {
                    font.InsertFont();
                    font.CheckFont();
                }
                style.font = font.font_id;
                style.UpdateStyle();
                LoadStyle();
                bs.DataSource = styleDT;
            }
        }

        private void bindingNavigatorEditParItem_Click(object sender, EventArgs e)
        {
            InitStyle();
            frmEditPar e_par = new frmEditPar(par);
            if (e_par.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                par = e_par._par; // переменная получает значение из формы
                par.CheckPar();
                if (par.paragraph_id == 0)
                {
                    par.InsertPar();
                    par.CheckPar();
                }
                style.paragraph = par.paragraph_id;
                style.UpdateStyle();
                LoadStyle();
                bs.DataSource = styleDT;
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            InitStyle();
            style = new StyleDesc();
            StyleTitle s_title = new StyleTitle();
            if (s_title.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                style.style_title = s_title.style_title;

                frmEditFont font_form = new frmEditFont();
                font_form._font = font;
                if (font_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    font = font_form._font; // переменная получает значение из формы
                    font.CheckFont();
                    if (font.font_id == 0)
                    {
                        font.InsertFont();
                        font.CheckFont();
                    }
                    style.font = font.font_id;

                    frmEditPar e_par = new frmEditPar(par);
                    e_par._par = par;
                    if (e_par.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        par = e_par._par; // переменная получает значение из формы
                        par.CheckPar();
                        if (par.paragraph_id == 0)
                        {
                            par.InsertPar();
                            par.CheckPar();
                        }
                        style.paragraph = par.paragraph_id;
                        style.InsertStyle();
                        LoadStyle();
                        bs.DataSource = styleDT;
                    }
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            style.DeleteStyle();
            LoadStyle();
            bs.DataSource = styleDT;
            OneItemCheck();
        }
    }
}
