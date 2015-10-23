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
using System.Data.SqlClient;

namespace FRC_System
{
    public partial class frmFont : Form
    {
        DataTable fontDT;
        public FormattingRulesLibrary.Font font;
        BindingSource bs = new BindingSource();
        public int font_id;

        public frmFont()
        {
            InitializeComponent();
            font = new FormattingRulesLibrary.Font();
            font.LoadFont(ref fontDT);
            bs.DataSource = fontDT;
            fontBindingNavigator.BindingSource = bs;
            tbSize.DataBindings.Add(new Binding("Text", bs, "size"));
            tbFTitle.DataBindings.Add(new Binding("Text", bs, "font_title"));
            tbColor.DataBindings.Add(new Binding("Text", bs, "color"));
            chbCurs.DataBindings.Add(new Binding("Checked", bs, "italic"));
            chbZh.DataBindings.Add(new Binding("Checked", bs, "bold"));
            chPodch.DataBindings.Add(new Binding("Checked", bs, "underlined"));
        }

        private void frmFont_Load(object sender, EventArgs e)
        {
            InitFont();
            OneItemCheck();
        }

        private void OneItemCheck() // проверка на присутствие только одного элемента
        {
            if (fontDT.Rows.Count == 1)
                bindingNavigatorDeleteItem.Enabled = false;
            else
                bindingNavigatorDeleteItem.Enabled = true;
        }

        private void InitFont()
        {
            font.font_id = (int)fontDT.Rows[bs.Position]["font_id"];
            font.font_title = (int)fontDT.Rows[bs.Position]["font_title_id"];
            font.size = double.Parse(fontDT.Rows[bs.Position]["size"].ToString());
            font.italic = (bool)fontDT.Rows[bs.Position]["italic"];
            font.underlined = (bool)fontDT.Rows[bs.Position]["underlined"];
            font.bold = (bool)fontDT.Rows[bs.Position]["bold"];
            font.color = (int)fontDT.Rows[bs.Position]["color_id"];
        }


        private void fontBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            InitFont();
            OneItemCheck();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            InitFont();
            font_id = font.font_id;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            font.DeleteFont();
            font.LoadFont(ref fontDT);
            bs.DataSource = fontDT;
            OneItemCheck();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmEditFont e_font = new frmEditFont();
            e_font._font = font;
            if (e_font.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                font = e_font._font; // переменная получает значение из формы
                font.InsertFont();
                font.LoadFont(ref fontDT); ;
                bs.DataSource = fontDT;
            }
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            InitFont();
            font.FillFontGaps();
            frmEditFont e_font = new frmEditFont(font);
            if (e_font.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                font = e_font._font; // переменная получает значение из формы
                font.UpdateFont();
                font.LoadFont(ref fontDT);
                bs.DataSource = fontDT;
            }
        }
    }
}
