namespace GizBook
{
    partial class frmConfirmLogout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfirmLogout));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Confirm_logout_Text;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(140, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 42);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(236, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(104, 100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(117, 250);
            panel3.Name = "panel3";
            panel3.Size = new Size(353, 24);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.confirm_button;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(301, 292);
            panel4.Name = "panel4";
            panel4.Size = new Size(159, 47);
            panel4.TabIndex = 3;
            panel4.Click += panel4_Click;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.cancel_button;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(128, 292);
            panel5.Name = "panel5";
            panel5.Size = new Size(157, 47);
            panel5.TabIndex = 4;
            panel5.Click += panel5_Click;
            // 
            // frmConfirmLogout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(564, 398);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConfirmLogout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConfirmLogout";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}