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
            btnAddDeck1 = new Button();
            btnAddDeck2 = new Button();
            btnAddDeck3 = new Button();
            btnAddDeck4 = new Button();
            btnAddDeck5 = new Button();
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
            deckContainer.Controls.Add(btnAddDeck1);
            deckContainer.Controls.Add(btnAddDeck2);
            deckContainer.Controls.Add(btnAddDeck3);
            deckContainer.Controls.Add(btnAddDeck4);
            deckContainer.Controls.Add(btnAddDeck5);
            deckContainer.Location = new Point(130, 187);
            deckContainer.Name = "deckContainer";
            deckContainer.Size = new Size(1231, 825);
            deckContainer.TabIndex = 5;
            deckContainer.Paint += deckContainer_Paint;
            // 
            // btnAddDeck1
            // 
            btnAddDeck1.BackgroundImage = (Image)resources.GetObject("btnAddDeck1.BackgroundImage");
            btnAddDeck1.BackgroundImageLayout = ImageLayout.Center;
            btnAddDeck1.Location = new Point(3, 3);
            btnAddDeck1.Name = "btnAddDeck1";
            btnAddDeck1.Size = new Size(213, 116);
            btnAddDeck1.TabIndex = 0;
            btnAddDeck1.UseVisualStyleBackColor = true;
            btnAddDeck1.Click += btnAddDeck_Click;
            // 
            // btnAddDeck2
            // 
            btnAddDeck2.BackgroundImage = (Image)resources.GetObject("btnAddDeck2.BackgroundImage");
            btnAddDeck2.BackgroundImageLayout = ImageLayout.Center;
            btnAddDeck2.Location = new Point(222, 3);
            btnAddDeck2.Name = "btnAddDeck2";
            btnAddDeck2.Size = new Size(213, 116);
            btnAddDeck2.TabIndex = 1;
            btnAddDeck2.UseVisualStyleBackColor = true;
            // 
            // btnAddDeck3
            // 
            btnAddDeck3.BackgroundImage = (Image)resources.GetObject("btnAddDeck3.BackgroundImage");
            btnAddDeck3.BackgroundImageLayout = ImageLayout.Center;
            btnAddDeck3.Location = new Point(441, 3);
            btnAddDeck3.Name = "btnAddDeck3";
            btnAddDeck3.Size = new Size(213, 116);
            btnAddDeck3.TabIndex = 2;
            btnAddDeck3.UseVisualStyleBackColor = true;
            // 
            // btnAddDeck4
            // 
            btnAddDeck4.BackgroundImage = (Image)resources.GetObject("btnAddDeck4.BackgroundImage");
            btnAddDeck4.BackgroundImageLayout = ImageLayout.Center;
            btnAddDeck4.Location = new Point(660, 3);
            btnAddDeck4.Name = "btnAddDeck4";
            btnAddDeck4.Size = new Size(213, 116);
            btnAddDeck4.TabIndex = 3;
            btnAddDeck4.UseVisualStyleBackColor = true;
            // 
            // btnAddDeck5
            // 
            btnAddDeck5.BackgroundImage = (Image)resources.GetObject("btnAddDeck5.BackgroundImage");
            btnAddDeck5.BackgroundImageLayout = ImageLayout.Center;
            btnAddDeck5.Location = new Point(879, 3);
            btnAddDeck5.Name = "btnAddDeck5";
            btnAddDeck5.Size = new Size(213, 116);
            btnAddDeck5.TabIndex = 4;
            btnAddDeck5.UseVisualStyleBackColor = true;
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
        private Button btnAddDeck1;
        private Button btnAddDeck2;
        private Button btnAddDeck3;
        private Button btnAddDeck4;
        private Button btnAddDeck5;
        public FlowLayoutPanel deckContainer;
    }
}