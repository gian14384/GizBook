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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (UserStore.Users.ContainsKey(username))
            {
                MessageBox.Show("Username already exist.");
            }
            else
            {
                UserStore.Users.Add(username, password);
                MessageBox.Show("Registered succesfully");
                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }
    }
}
