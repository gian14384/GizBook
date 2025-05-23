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
    public partial class frmRegisterAvatar : Form
    {
        public frmRegisterAvatar()
        {
            InitializeComponent();
        }




        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            frmRegister f2 = new frmRegister();
            f2.Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {

        }

        private void avatar1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\gb1.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void frmRegisterAvatar_Load(object sender, EventArgs e)
        {
            placeholdername.ReadOnly = true;
            placeholdername.Cursor = Cursors.Default;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\bb1.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\gb2.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\bb2.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\gb3.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\bb3.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\gb4.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\bb4.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\gb5.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\bb5.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\gb6.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            string newImagePath = @"D:\Final Project\Images\rv2\bb6.png"; // Image for pictureBox2
            if (System.IO.File.Exists(newImagePath))
            {
                picholder.BackgroundImage = Image.FromFile(newImagePath);
            }
            else
            {
                MessageBox.Show("Image file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Hide();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            frmHomePage fhp = new frmHomePage();
            fhp.Show();
            this.Hide();
        }

        private void placeholdername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
