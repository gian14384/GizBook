using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace GizBook
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }



        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;   // Used for login
            string password = txtpassword.Text;
            string confirmPass = txtconfirm.Text;
            string fullName = txtname.Text;   // Actual full name of the user

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPass) || string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please fill in all required fields.");
                txtusername.Clear();
                txtpassword.Clear();
                txtconfirm.Clear();
                txtname.Clear();
            }
            else
            {
                if (password == confirmPass)
                {
                    if (UserStore.UserPasswords.ContainsKey(username))
                    {
                        MessageBox.Show("Username already exists.");
                    }
                    else
                    {
                        // Store username-password and username-full name separately
                        UserStore.UserPasswords.Add(username, password);
                        UserStore.UserNames.Add(username, fullName);

                        MessageBox.Show("Registration successful!");
                        frmRegisterAvatar f3 = new frmRegisterAvatar();
                        f3.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match.");
                    txtpassword.Clear();
                    txtconfirm.Clear();
                }
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            frmLogin f1 = new frmLogin();
            f1.Show();
            this.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
