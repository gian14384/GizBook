namespace GizBook
{
    partial class DeckControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            lblCardCount = new Label();
            deckColorPanel = new Panel();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(3, 60);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(65, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "label1";
            // 
            // lblCardCount
            // 
            lblCardCount.AutoSize = true;
            lblCardCount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCardCount.Location = new Point(5, 85);
            lblCardCount.Name = "lblCardCount";
            lblCardCount.Size = new Size(52, 21);
            lblCardCount.TabIndex = 1;
            lblCardCount.Text = "label2";
            lblCardCount.Click += lblCardCount_Click;
            // 
            // deckColorPanel
            // 
            deckColorPanel.BackColor = Color.Transparent;
            deckColorPanel.BackgroundImageLayout = ImageLayout.Center;
            deckColorPanel.Location = new Point(0, 0);
            deckColorPanel.Name = "deckColorPanel";
            deckColorPanel.Size = new Size(213, 43);
            deckColorPanel.TabIndex = 2;
            // 
            // DeckControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deckColorPanel);
            Controls.Add(lblCardCount);
            Controls.Add(titleLabel);
            Name = "DeckControl";
            Size = new Size(213, 116);
            Load += DeckControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label lblCardCount;
        public Panel deckColorPanel;
    }
}
