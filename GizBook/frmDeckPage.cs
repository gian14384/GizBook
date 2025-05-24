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

        public DeckControl deckControlInstance; // Declare instance

private void frmDeckPage_Load(object sender, EventArgs e)
{
    deckControlInstance = new DeckControl(); // Initialize DeckControl
    Controls.Add(deckControlInstance); // Add it directly to the form

            deckContainer.FlowDirection = FlowDirection.LeftToRight;
            deckContainer.AutoScroll = true;
            foreach (Control ctrl in deckContainer.Controls)
            {
                ctrl.Margin = new Padding(15); // Adds 10px space around each button
            }
            deckContainer.Padding = new Padding(5); // Adds 5px padding inside the panel

            if (btnAddDeck1.Visible)
            {
                btnAddDeck2.Visible = false;
                btnAddDeck3.Visible = false;
                btnAddDeck4.Visible = false;
                btnAddDeck5.Visible = false;
            }
        }

        public void UpdateDeckControlColor(int r, int g, int b)
        {
            DeckControl deckControlInstance = deckContainer.Controls.OfType<DeckControl>().FirstOrDefault();

            if (deckControlInstance != null)
            {
                deckControlInstance.UpdateDeckColor(r, g, b);
            }
            else
            {
                MessageBox.Show("DeckControl not found in panelContainer.");
            }
        }


     

        private void btnAddDeck_Click(object sender, EventArgs e)
        {
            frmAddDeck fad = new frmAddDeck();
            fad.Show();
        }

        private void deckContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
