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
    public partial class DeckControl : UserControl
    {
        public DeckControl()
        {
            InitializeComponent();
        }

        public void UpdateDeck(string newTitle, Color newColor)
        {
            lblTitle.Text = newTitle;
            this.BackColor = newColor;
        }

        private void DeckControl_Load(object sender, EventArgs e)
        {

        }

        private void lblCardCount_Click(object sender, EventArgs e)
        {

        }
    }
}
