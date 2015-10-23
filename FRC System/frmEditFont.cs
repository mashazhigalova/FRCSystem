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

namespace FRC_System
{
    public partial class frmEditFont : Form
    {
        public FormattingRulesLibrary.Font _font = new FormattingRulesLibrary.Font();
        int font_id;

        public frmEditFont()
        {
            InitializeComponent();
        }

        public frmEditFont(FormattingRulesLibrary.Font font)
        {
            InitializeComponent();
            font_id = font.font_id;
            _font.font_id = font_id;
            _font = font;
        }

        private void frmEditFont_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formatting_rules_DBDataSet.Color' table. You can move, or remove it, as needed.
            this.colorTableAdapter.Fill(this.formatting_rules_DBDataSet.Color);
            // TODO: This line of code loads data into the 'formatting_rules_DBDataSet.FontTitle' table. You can move, or remove it, as needed.
            this.fontTitleTableAdapter.Fill(this.formatting_rules_DBDataSet.FontTitle);

            numFontSize.Value = (decimal)_font.size;
            cbFontColor.SelectedValue = _font.color;
            cbFontName.SelectedValue = _font.font_title;
            chbZh.Checked = _font.bold;
            chbCurs.Checked = _font.italic;
            chPodch.Checked = _font.underlined;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double size = (double)numFontSize.Value;
            _font = new FormattingRulesLibrary.Font((int)cbFontName.SelectedValue, size, chbCurs.Checked, chPodch.Checked, chbZh.Checked, (int)cbFontColor.SelectedValue);
            _font.font_id = font_id;
        }
    }
}
