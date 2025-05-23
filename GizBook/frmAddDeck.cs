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

            btn1.Tag = "255, 138, 101";
            btn2.Tag = "255, 213, 79";
            btn3.Tag = "79, 195, 247";
            btn4.Tag = "129, 199, 132";
            btn5.Tag = "186, 104, 200";
            btn6.Tag = "240, 98, 146";
            btn7.Tag = "161, 136, 127";
            btn8.Tag = "144, 164, 174";
            btn9.Tag = "121, 134, 203";
            btn10.Tag = "229, 155, 155";

            // Assign event to all buttons
            btn1.Click += ColorButton_Click;
            btn2.Click += ColorButton_Click;
            btn3.Click += ColorButton_Click;
            btn4.Click += ColorButton_Click;
            btn5.Click += ColorButton_Click;
            btn6.Click += ColorButton_Click;
            btn7.Click += ColorButton_Click;
            btn8.Click += ColorButton_Click;
            btn9.Click += ColorButton_Click;
            btn10.Click += ColorButton_Click;
        }
        private int r, g, b; // Store selected RGB values

        private void ColorButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button clickedButton) return; // Ensure sender is valid

            string[] rgbArray = clickedButton.Tag?.ToString().Split(',') ?? Array.Empty<string>();
            if (rgbArray.Length < 3) return; // Avoid crashes

            int r = int.Parse(rgbArray[0]);
            int g = int.Parse(rgbArray[1]);
            int b = int.Parse(rgbArray[2]);

            selectedDeckColor = Color.FromArgb(r, g, b);
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
            string title = txtDeckTitle.Text;

            // Validate that a color was selected
            if (selectedDeckColor == null)
            {
                MessageBox.Show("Please select a deck color!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Deck newDeck = new Deck(title, 0, selectedDeckColor); // Create deck with color
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            selectedDeckColor = clickedButton.BackColor;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAddDeck_Load(object sender, EventArgs e)
        {

        }
    }
}
