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
    public partial class frmPaperFormat : Form
    {

        public frmPaperFormat()
        {
            InitializeComponent();
        }

        private void frmPaperFormat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formatting_rules_DBDataSet.PaperFormat' table. You can move, or remove it, as needed.
            this.paperFormatTableAdapter.Fill(this.formatting_rules_DBDataSet.PaperFormat);
            OneItemCheck();
        }

        private void формат_бумагиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
             this.paperFormatBindingSource.EndEdit();
            this.paperFormatTableAdapter.Update(this.formatting_rules_DBDataSet.PaperFormat);
        }

        private void OneItemCheck() // проверка на присутствие только одного элемента
        {
            if (dgvPFormats.Rows.Count == 1)
                bindingNavigatorDeleteItem.Enabled = false;
            else
                bindingNavigatorDeleteItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            OneItemCheck();
        }

        private void tbPaperFormat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tbWidgth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tbLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

    }
}
