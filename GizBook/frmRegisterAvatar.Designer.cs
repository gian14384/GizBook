namespace GizBook
{
    partial class frmRegisterAvatar
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Frame_427318940;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(194, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 701);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Add_Profile;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(277, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(521, 41);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.Choose_Your_Avatar;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(332, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(408, 58);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.Frame_427318942;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(288, 137);
            panel4.Name = "panel4";
            panel4.Size = new Size(488, 353);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.Frame_57;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(261, 512);
            panel5.Name = "panel5";
            panel5.Size = new Size(252, 68);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.Frame;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Location = new Point(243, 400);
            panel6.Name = "panel6";
            panel6.Size = new Size(267, 46);
            panel6.TabIndex = 4;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.Frame1;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Location = new Point(231, 400);
            panel7.Name = "panel7";
            panel7.Size = new Size(267, 46);
            panel7.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackgroundImage = Properties.Resources.Frame2;
            panel8.BackgroundImageLayout = ImageLayout.Center;
            panel8.Location = new Point(519, 512);
            panel8.Name = "panel8";
            panel8.Size = new Size(281, 68);
            panel8.TabIndex = 4;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            ClientSize = new Size(1440, 1024);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel7;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Panel panel8;
    }
}