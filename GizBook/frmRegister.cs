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
            string username = txtusername.Text;
            string password = txtpassword.Text;
            string confirmpass = txtconfirm.Text;
            string name = txtname.Text;

            if (username == "" || password == "" || confirmpass == "" || name == "")
            {
                MessageBox.Show("Input all the info needed");
                txtusername.Text = "";
                txtpassword.Text = "";
                txtconfirm.Text = "";
                txtname.Text = "";
            }
            else
            {
                if (password == confirmpass)
                {
                    if (UserStore.Users.ContainsKey(username))
                    {
                        MessageBox.Show("Username already exist.");
                    }
                    else
                    {
                        UserStore.Users.Add(username, password);
                        MessageBox.Show("Registered succesfully");
                        frmLogin f1 = new frmLogin();
                        f1.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Password did not match");
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    txtconfirm.Text = "";
                    txtname.Text = "";
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
    }
}
