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
            int panelHeight1 = paneldropdown1.Visible ? paneldropdown1.Height : 0;
            paneldropdown1.Visible = !paneldropdown1.Visible;
            btndropdown2.Top = paneldropdown1.Visible ? btndropdown2.Top + paneldropdown1.Height : btndropdown2.Top - panelHeight1;
            btndropdown3.Top = paneldropdown1.Visible ? btndropdown3.Top + paneldropdown1.Height : btndropdown3.Top - panelHeight1;
        }

        private void btndropdown2_Click(object sender, EventArgs e)
        {


        }

        private void btndropdown2_Click_1(object sender, EventArgs e)
        {

        }

        private void btndropdown3_Click(object sender, EventArgs e)
        {

        }

        private void frmFAQ_Load(object sender, EventArgs e)
        {

        }

        private void btndropdown2_Click_2(object sender, EventArgs e)
        {
            int panelHeight2 = paneldropdown2.Visible ? paneldropdown2.Height : 0;
            paneldropdown2.Visible = !paneldropdown2.Visible;
            btndropdown3.Top = paneldropdown2.Visible ? btndropdown3.Top + paneldropdown2.Height : btndropdown3.Top - panelHeight2;
        }
    }
}
