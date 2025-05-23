namespace GizBook
{
    partial class frmDeckPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeckPage));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            deckContainer = new FlowLayoutPanel();
            btnAddDeck = new Button();
            panel1.SuspendLayout();
            deckContainer.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(82, 1029);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(76, 74);
            panel2.TabIndex = 1;
            panel2.Click += panel2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(130, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 48);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(766, 29);
            panel4.Name = "panel4";
            panel4.Size = new Size(287, 61);
            panel4.TabIndex = 2;
            panel4.Click += panel4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(1074, 29);
            panel5.Name = "panel5";
            panel5.Size = new Size(287, 61);
            panel5.TabIndex = 3;
            panel5.Click += panel5_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Location = new Point(130, 154);
            panel6.Name = "panel6";
            panel6.Size = new Size(1231, 16);
            panel6.TabIndex = 4;
            // 
            // deckContainer
            // 
            deckContainer.Controls.Add(btnAddDeck);
            deckContainer.Location = new Point(130, 187);
            deckContainer.Name = "deckContainer";
            deckContainer.Size = new Size(1231, 825);
            deckContainer.TabIndex = 5;
            // 
            // btnAddDeck
            // 
            btnAddDeck.BackgroundImage = (Image)resources.GetObject("btnAddDeck.BackgroundImage");
            btnAddDeck.BackgroundImageLayout = ImageLayout.Center;
            btnAddDeck.Location = new Point(3, 3);
            btnAddDeck.Name = "btnAddDeck";
            btnAddDeck.Size = new Size(213, 116);
            btnAddDeck.TabIndex = 0;
            btnAddDeck.UseVisualStyleBackColor = true;
            btnAddDeck.Click += btnAddDeck_Click;
            // 
            // frmDeckPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1440, 1024);
            Controls.Add(deckContainer);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDeckPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDeckPage";
            Load += frmDeckPage_Load;
            panel1.ResumeLayout(false);
            deckContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private FlowLayoutPanel deckContainer;
        private Button btnAddDeck;
    }
}