using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormattingRulesLibrary;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FRC_System
{
    public partial class frmNumeration : Form
    {
        DataTable numDT = new DataTable();
        public Numeration num;
        BindingSource bs = new BindingSource();
        public int num_id;

        public frmNumeration()
        {
            InitializeComponent();
            num = new Numeration();
            LoadNumeration();
            bs.DataSource = numDT;
            numBindingNavigator.BindingSource = bs;
            tbLoc.DataBindings.Add(new Binding("Text", bs, "location"));
        }

        private void frmNumeration_Load(object sender, EventArgs e)
        {
            InitNum();
        }

        private void LoadNumeration()    // загрузка нумерации
        {
            SqlConnection con = new SqlConnection(@"Data Source=MARIAZHIGALOVA\MARIAZHIGALOVA;Initial Catalog=formatting_rules_DB;Integrated Security=True");

            SqlCommand comNum = con.CreateCommand();
            comNum.CommandText = @"SELECT        Location.location_id, Location.location, Numeration.numeration_id 
                                    FROM            Location INNER JOIN
                         Numeration ON Location.location_id = Numeration.location";
            SqlDataAdapter adaptFNum = new SqlDataAdapter(comNum);
            numDT = new DataTable();
            try
            {
                con.Open();
                adaptFNum.Fill(numDT);
            }
            finally
            {
                con.Close();
            }
        }

        private void numBindingNavigator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            InitNum();
        }

        private void InitNum()
        {
            num.numeration_id = (int)numDT.Rows[bs.Position]["numeration_id"];
            num.location = (int)numDT.Rows[bs.Position]["location_id"];
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmEditNum e_num = new frmEditNum();
            e_num._num = num;
            if (e_num.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                num = e_num._num; // переменная получает значение из формы
                num.AddNum();
                LoadNumeration();
                bs.DataSource = numDT;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            num.DeleteNum();
            LoadNumeration();
            bs.DataSource = numDT;
        }

        private void bindingNavigatorEditItem_Click(object sender, EventArgs e)
        {
            InitNum();
            num.FillGaps();
            frmEditNum e_num = new frmEditNum(num);
            if (e_num.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                num = e_num._num; // переменная получает значение из формы
                num.UpdateNum();
                LoadNumeration();
                bs.DataSource = numDT;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            InitNum();
            num_id = num.numeration_id;
        }
    }
}
