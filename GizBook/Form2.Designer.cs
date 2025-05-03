namespace GizBook
{
    partial class Form2
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
            txtname = new TextBox();
            panel3 = new Panel();
            txtusername = new TextBox();
            panel4 = new Panel();
            txtpassword = new TextBox();
            panel5 = new Panel();
            txtconfirm = new TextBox();
            panel6 = new Panel();
            panel7 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Frame_427318941;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(463, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 121);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.Name;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(463, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(61, 20);
            panel2.TabIndex = 1;
            // 
            // txtname
            // 
            txtname.BorderStyle = BorderStyle.None;
            txtname.Location = new Point(463, 261);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(582, 56);
            txtname.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = Properties.Resources.Username1;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(463, 323);
            panel3.Name = "panel3";
            panel3.Size = new Size(77, 27);
            panel3.TabIndex = 5;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Location = new Point(463, 356);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(582, 56);
            txtusername.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.Password1;
            panel4.BackgroundImageLayout = ImageLayout.Center;
            panel4.Location = new Point(463, 418);
            panel4.Name = "panel4";
            panel4.Size = new Size(74, 32);
            panel4.TabIndex = 7;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Location = new Point(463, 456);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(582, 56);
            txtpassword.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.Confirm_Password;
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(463, 518);
            panel5.Name = "panel5";
            panel5.Size = new Size(124, 36);
            panel5.TabIndex = 9;
            // 
            // txtconfirm
            // 
            txtconfirm.BorderStyle = BorderStyle.None;
            txtconfirm.Location = new Point(463, 560);
            txtconfirm.Multiline = true;
            txtconfirm.Name = "txtconfirm";
            txtconfirm.Size = new Size(582, 56);
            txtconfirm.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Sign_up;
            panel6.BackgroundImageLayout = ImageLayout.Center;
            panel6.Location = new Point(463, 622);
            panel6.Name = "panel6";
            panel6.Size = new Size(582, 86);
            panel6.TabIndex = 11;
            panel6.Click += panel6_Click;
            panel6.Paint += panel6_Paint;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.Already_have_an_account__Sign_in_instead_;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Location = new Point(612, 714);
            panel7.Name = "panel7";
            panel7.Size = new Size(287, 43);
            panel7.TabIndex = 12;
            panel7.Click += panel7_Click;
            panel7.Paint += panel7_Paint;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            ClientSize = new Size(1440, 1024);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(txtconfirm);
            Controls.Add(panel5);
            Controls.Add(txtpassword);
            Controls.Add(panel4);
            Controls.Add(txtusername);
            Controls.Add(panel3);
            Controls.Add(txtname);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtname;
        private Panel panel3;
        private TextBox txtusername;
        private Panel panel4;
        private TextBox txtpassword;
        private Panel panel5;
        private TextBox txtconfirm;
        private Panel panel6;
        private Panel panel7;
    }
}