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
    public partial class frmDeckPage : Form
    {
        public frmDeckPage()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            frmHomePage frmHomePage = new frmHomePage();
            frmHomePage.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            frmLearningMode flm = new frmLearningMode();
            flm.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            frmAddDeck fad = new frmAddDeck();
            fad.Show();
        }
    }
}
