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
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }
        public void SetFullName(string fullName)
        {
            name.Text = fullName;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {

        }
        private bool showingFirstImage = true;

        private void btnsettings_Click(object sender, EventArgs e)
        {
            if (showingFirstImage)
            {
                btndropdown.BackgroundImage = Image.FromFile("D:\\Final Project\\Images\\homepage\\settings.png");
            }
            else
            {
                btndropdown.BackgroundImage = Image.FromFile("D:\\Final Project\\Images\\homepage\\header.png");
            }

            btndropdown.BackgroundImageLayout = ImageLayout.Center;
            showingFirstImage = !showingFirstImage;


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            btnadd.Top = panelDropdown.Visible ? btnadd.Top + panelDropdown.Height : btnadd.Top - panelHeight;
        }

        private void btndropdown_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            btnadd.Top = panelDropdown.Visible ? btnadd.Top + panelDropdown.Height : btnadd.Top - panelHeight;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            btnadd.Top = panelDropdown.Visible ? btnadd.Top + panelDropdown.Height : btnadd.Top - panelHeight;

            frmChangePrivacy fcp = new frmChangePrivacy();
            fcp.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            btnadd.Top = panelDropdown.Visible ? btnadd.Top + panelDropdown.Height : btnadd.Top - panelHeight;
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            btnadd.Top = panelDropdown.Visible ? btnadd.Top + panelDropdown.Height : btnadd.Top - panelHeight;

            frmContactUs fcs = new frmContactUs();
            fcs.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int panelHeight = panelDropdown.Visible ? panelDropdown.Height : 0;
            panelDropdown.Visible = !panelDropdown.Visible;

            panel7.Top = panelDropdown.Visible ? panel7.Top + panelDropdown.Height : panel7.Top - panelHeight;
            btnadd.Top = panelDropdown.Visible ? btnadd.Top + panelDropdown.Height : btnadd.Top - panelHeight;

            frmConfirmLogout fcl = new frmConfirmLogout();
            fcl.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            panel10.Visible = true;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
            panel10.Visible = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmAddDeck fad = new frmAddDeck();
            fad.Show();
        }
    }
}
