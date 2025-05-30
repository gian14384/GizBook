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
    public partial class frmProfilePage : Form
    {
        public frmProfilePage()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmHomePage fhp = new frmHomePage();
            fhp.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            mark1.Visible = !mark1.Visible;
            mark2.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;
            pnlfriends.Visible = false;
            pnlstats.Visible = false;
            pnldecks.Visible = false;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            mark2.Visible = !mark2.Visible;
            pnldecks.Visible = !pnldecks.Visible;
            mark1.Visible = false;
            mark3.Visible = false;
            mark4.Visible = false;
            pnlfriends.Visible = false;
            pnlstats.Visible = false;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            mark3.Visible = !mark3.Visible;
            mark1.Visible = false;
            mark2.Visible = false;
            mark4.Visible = false;
            pnlfriends.Visible = false;
            pnlstats.Visible = !pnlstats.Visible;
            pnldecks.Visible = false;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            mark4.Visible = !mark4.Visible;
            pnlfriends.Visible = !pnlfriends.Visible;
            mark1.Visible = false;
            mark2.Visible = false;
            mark3.Visible = false;
            pnlstats.Visible = false;
            pnldecks.Visible = false;
        }

        private void mark2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {

        }
    }
}
