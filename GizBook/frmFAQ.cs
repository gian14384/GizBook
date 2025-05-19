using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizBook
{
    public partial class frmFAQ : Form
    {
        public frmFAQ()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmHomePage fhp = new frmHomePage();
            fhp.Show();
            this.Hide();
        }

        private void btndropdown1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndropdown1_Click(object sender, EventArgs e)
        {
            int panelHeight = paneldropdown1.Visible ? paneldropdown1.Height : 0;
            paneldropdown1.Visible = !paneldropdown1.Visible;
        }
    }
}
