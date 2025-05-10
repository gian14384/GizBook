namespace GizBook
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Group_53;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(125, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 120);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.Frame_22;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Cursor = Cursors.Hand;
            panel5.Location = new Point(125, 419);
            panel5.Name = "panel5";
            panel5.Size = new Size(584, 53);
            panel5.TabIndex = 6;
            panel5.Click += panel5_Click;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Don_t_have_an_account__Create_one;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Cursor = Cursors.Hand;
            panel6.Location = new Point(297, 478);
            panel6.Name = "panel6";
            panel6.Size = new Size(244, 28);
            panel6.TabIndex = 7;
            panel6.Click += panel6_Click;
            panel6.Paint += panel6_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.title;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Location = new Point(375, 935);
            panel7.Name = "panel7";
            panel7.Size = new Size(151, 42);
            panel7.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.title__1_;
            panel8.BackgroundImageLayout = ImageLayout.Center;
            panel8.Location = new Point(671, 935);
            panel8.Name = "panel8";
            panel8.Size = new Size(162, 42);
            panel8.TabIndex = 9;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.BackgroundImage = Properties.Resources.title__2_;
            panel9.BackgroundImageLayout = ImageLayout.Center;
            panel9.Location = new Point(965, 935);
            panel9.Name = "panel9";
            panel9.Size = new Size(145, 42);
            panel9.TabIndex = 10;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.BackgroundImage = (Image)resources.GetObject("panel10.BackgroundImage");
            panel10.BackgroundImageLayout = ImageLayout.Center;
            panel10.Controls.Add(panel12);
            panel10.Controls.Add(panel11);
            panel10.Controls.Add(panel4);
            panel10.Controls.Add(panel3);
            panel10.Controls.Add(panel2);
            panel10.Controls.Add(panel1);
            panel10.Controls.Add(panel5);
            panel10.Controls.Add(panel6);
            panel10.Controls.Add(txtusername);
            panel10.Controls.Add(txtpassword);
            panel10.Location = new Point(326, 244);
            panel10.Name = "panel10";
            panel10.Size = new Size(840, 568);
            panel10.TabIndex = 11;
            // 
            // panel12
            // 
            panel12.BackgroundImage = (Image)resources.GetObject("panel12.BackgroundImage");
            panel12.BackgroundImageLayout = ImageLayout.Center;
            panel12.Cursor = Cursors.Hand;
            panel12.Location = new Point(645, 328);
            panel12.Name = "panel12";
            panel12.Size = new Size(45, 42);
            panel12.TabIndex = 18;
            panel12.Click += panel12_Click;
            panel12.Paint += panel12_Paint;
            // 
            // panel11
            // 
            panel11.BackgroundImage = (Image)resources.GetObject("panel11.BackgroundImage");
            panel11.BackgroundImageLayout = ImageLayout.Center;
            panel11.Location = new Point(125, 324);
            panel11.Name = "panel11";
            panel11.Size = new Size(43, 48);
            panel11.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.profile;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(125, 237);
            panel4.Name = "panel4";
            panel4.Size = new Size(43, 48);
            panel4.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(175, 371);
            panel3.Name = "panel3";
            panel3.Size = new Size(515, 2);
            panel3.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(175, 284);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 2);
            panel2.TabIndex = 13;
            // 
            // txtusername
            // 
            txtusername.BackColor = SystemColors.Window;
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Cursor = Cursors.IBeam;
            txtusername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(174, 243);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Username";
            txtusername.Size = new Size(532, 48);
            txtusername.TabIndex = 16;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = SystemColors.Window;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(177, 330);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(532, 48);
            txtpassword.TabIndex = 17;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1440, 1024);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel11;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Panel panel12;
    }
}
