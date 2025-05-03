namespace GizBook
{
    partial class Form1
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Group_53;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(442, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 210);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Username;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(442, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(84, 48);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Password;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(442, 435);
            panel3.Name = "panel3";
            panel3.Size = new Size(77, 51);
            panel3.TabIndex = 2;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(442, 373);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(582, 56);
            txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Location = new Point(442, 492);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(528, 56);
            txtpassword.TabIndex = 4;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.Window;
            panel4.BackgroundImage = Properties.Resources.btn_pw;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(976, 492);
            panel4.Name = "panel4";
            panel4.Size = new Size(51, 56);
            panel4.TabIndex = 5;
            panel4.Click += panel4_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.Frame_22;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(443, 566);
            panel5.Name = "panel5";
            panel5.Size = new Size(584, 69);
            panel5.TabIndex = 6;
            panel5.Click += panel5_Click;
            panel5.Paint += panel5_Paint;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Don_t_have_an_account__Create_one;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Location = new Point(622, 641);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1440, 1024);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
    }
}
