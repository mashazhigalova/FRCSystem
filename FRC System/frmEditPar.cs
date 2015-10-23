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
    public partial class frmEditPar : Form
    {
        public FormattingRulesLibrary.Paragraph _par = new FormattingRulesLibrary.Paragraph();
        public int par_id;

        public frmEditPar()
        {
            InitializeComponent();
        }

        public frmEditPar(FormattingRulesLibrary.Paragraph par)
        {
            InitializeComponent();
            par_id = par.paragraph_id;
            _par.paragraph_id = par_id;
            _par = par;
        }

        private void frmEditPar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formatting_rules_DBDataSet.Alignment' table. You can move, or remove it, as needed.
            this.alignmentTableAdapter.Fill(this.formatting_rules_DBDataSet.Alignment);

            cbAlign.SelectedValue = _par.align;
            numLeft.Value = (decimal)_par.left_indent;
            numRight.Value = (decimal)_par.right_indent;
            numOtst.Value = (decimal)_par.indent_1st_string;
            numBefore.Value = (decimal)_par.interval_before;
            numAfter.Value = (decimal)_par.interval_after;
            numStrInt.Value = (decimal)_par.interval_between;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _par = new FormattingRulesLibrary.Paragraph((int)cbAlign.SelectedValue, (double)numLeft.Value, (double)numRight.Value, (double)numOtst.Value,
                (double)numBefore.Value, (double)numAfter.Value, (double)numStrInt.Value);
            _par.paragraph_id = par_id;
        }
    }
}
