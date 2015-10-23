using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRC_System
{
    public partial class frmColont : Form
    {
        public int col_id;

        public frmColont()
        {
            InitializeComponent();
        }

        private void frmColont_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formatting_rules_DBDataSet.Colont' table. You can move, or remove it, as needed.
            this.colontTableAdapter.Fill(this.formatting_rules_DBDataSet.Colont);
            OneItemCheck();
        }

        private void колонтитулBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colontBindingSource.EndEdit();
            this.colontTableAdapter.Update(this.formatting_rules_DBDataSet.Colont);
            
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            try
            {
                col_id = (int)formatting_rules_DBDataSet.Colont.Rows[dgvColont.SelectedRows[0].Index]["colont_id"];
            }
            catch (Exception) { System.Windows.Forms.MessageBox.Show("Непредвиденная ситуация.\nЗакройте окно и попробуйте снова.", "Добавление колонтитула"); }
        }

        private void OneItemCheck() // проверка на присутствие только одного элемента
        {
            if (dgvColont.Rows.Count == 1)
                toolStripButton2.Enabled = false;
            else
                toolStripButton2.Enabled = true;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OneItemCheck();
        }

        private void tbBottomCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar.ToString() == "," && tbBottomCol.Text.IndexOf(',') == -1) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;       //Разрешение на ввод только цифр, одной запятой, одного знака минус 
            } 
        }

        private void tbUpCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(e.KeyChar.ToString() == "," && tbBottomCol.Text.IndexOf(',') == -1) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;       //Разрешение на ввод только цифр, одной запятой, одного знака минус 
            } 
        }
    }
}
