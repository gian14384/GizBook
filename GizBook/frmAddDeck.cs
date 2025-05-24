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
    public partial class frmAddDeck : Form
    {
        public frmAddDeck()
        {
            InitializeComponent();

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel20_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveDeck_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveDeck_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            int red = 255;
            int green = 138;
            int blue = 101;

            DeckControl form2 = new DeckControl();


            form2.UpdatePanelColor(red, green, blue);


            form2.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }



        private void frmAddDeck_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int red = 100;
            int green = 200;
            int blue = 150;

            // Get the active frmDeckPage instance
            frmDeckPage deckPageInstance = Application.OpenForms["frmDeckPage"] as frmDeckPage;

            if (deckPageInstance != null && deckPageInstance.deckControlInstance != null)
            {
                deckPageInstance.deckControlInstance.UpdateDeckColor(red, green, blue);
            }
            else
            {
                MessageBox.Show("frmDeckPage or DeckControl instance not found.");
            }
        }
    }
}
