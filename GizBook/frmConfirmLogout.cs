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
    public partial class frmConfirmLogout : Form
    {
        public frmConfirmLogout()
        {
            InitializeComponent();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            frmConfirmLogout frl = new frmConfirmLogout();
            this.Hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
