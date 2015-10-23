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
    public partial class frmEditNum : Form
    {
        public Numeration _num = new Numeration();
        int num_id;

        public frmEditNum()
        {
            InitializeComponent();
        }

        public frmEditNum(Numeration num)
        {
            InitializeComponent();
            num_id = num.numeration_id;
            _num.numeration_id = num_id;
            _num = num;
        }

        private void frmEditNum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'formatting_rules_DBDataSet.Location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.formatting_rules_DBDataSet.Location);

            cbPlace.SelectedValue = _num.location;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _num = new Numeration((int)cbPlace.SelectedValue);
            _num.numeration_id = num_id;
        }

    }
}
