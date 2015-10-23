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
    public partial class StyleTitle : Form
    {
        public string style_title; 

        public StyleTitle()
        {
            InitializeComponent();
            cmbStyle.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            style_title = cmbStyle.SelectedItem.ToString();
        }
    }
}
