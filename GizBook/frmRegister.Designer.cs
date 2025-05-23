namespace GizBook
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            panel1 = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            txtconfirm = new TextBox();
            txtpassword = new TextBox();
            txtusername = new TextBox();
            txtname = new TextBox();
            panel8 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Frame_427318962__1_;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(txtconfirm);
            panel1.Controls.Add(txtpassword);
            panel1.Controls.Add(txtusername);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(281, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 635);
            panel1.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.ForeColor = Color.Black;
            panel12.Location = new Point(204, 461);
            panel12.Name = "panel12";
            panel12.Size = new Size(532, 2);
            panel12.TabIndex = 12;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.ForeColor = Color.Black;
            panel11.Location = new Point(204, 374);
            panel11.Name = "panel11";
            panel11.Size = new Size(532, 2);
            panel11.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.ForeColor = Color.Black;
            panel10.Location = new Point(204, 285);
            panel10.Name = "panel10";
            panel10.Size = new Size(532, 2);
            panel10.TabIndex = 12;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.ForeColor = Color.Black;
            panel9.Location = new Point(204, 197);
            panel9.Name = "panel9";
            panel9.Size = new Size(532, 2);
            panel9.TabIndex = 11;
            // 
            // txtconfirm
            // 
            txtconfirm.BorderStyle = BorderStyle.None;
            txtconfirm.Cursor = Cursors.IBeam;
            txtconfirm.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtconfirm.Location = new Point(204, 422);
            txtconfirm.Multiline = true;
            txtconfirm.Name = "txtconfirm";
            txtconfirm.PlaceholderText = "Confirm Password";
            txtconfirm.Size = new Size(532, 48);
            txtconfirm.TabIndex = 10;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(204, 332);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PlaceholderText = "Password";
            txtpassword.Size = new Size(532, 48);
            txtpassword.TabIndex = 8;
            txtpassword.TextChanged += txtusername_TextChanged;
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.None;
            txtusername.Cursor = Cursors.IBeam;
            txtusername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusername.Location = new Point(201, 243);
            txtusername.Multiline = true;
            txtusername.Name = "txtusername";
            txtusername.PlaceholderText = "Username";
            txtusername.Size = new Size(532, 48);
            txtusername.TabIndex = 7;
            txtusername.TextChanged += txtusername_TextChanged_1;
            // 
            // txtname
            // 
            txtname.BackColor = SystemColors.Window;
            txtname.BorderStyle = BorderStyle.None;
            txtname.Cursor = Cursors.IBeam;
            txtname.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtname.Location = new Point(204, 156);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.PlaceholderText = "Name";
            txtname.Size = new Size(532, 48);
            txtname.TabIndex = 6;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // panel8
            // 
            panel8.BackgroundImage = Properties.Resources.Already_have_an_account__Sign_in_instead1;
            panel8.BackgroundImageLayout = ImageLayout.Center;
            panel8.Cursor = Cursors.Hand;
            panel8.Location = new Point(299, 566);
            panel8.Name = "panel8";
            panel8.Size = new Size(295, 28);
            panel8.TabIndex = 5;
            panel8.Click += panel8_Click;
            panel8.Paint += panel8_Paint;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.Sign_up1;
            panel7.BackgroundImageLayout = ImageLayout.Center;
            panel7.Cursor = Cursors.Hand;
            panel7.Location = new Point(155, 498);
            panel7.Name = "panel7";
            panel7.Size = new Size(581, 62);
            panel7.TabIndex = 4;
            panel7.Click += panel7_Click;
            panel7.Paint += panel7_Paint;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Center;
            panel5.Location = new Point(155, 328);
            panel5.Name = "panel5";
            panel5.Size = new Size(43, 48);
            panel5.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.profile;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(155, 150);
            panel3.Name = "panel3";
            panel3.Size = new Size(43, 48);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.Frame_4273189411;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(155, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 67);
            panel2.TabIndex = 0;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background2;
            ClientSize = new Size(1424, 985);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            Load += frmRegister_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel8;
        private Panel panel7;
        private Panel panel5;
        private Panel panel3;
        private TextBox txtpassword;
        private TextBox txtname;
        private TextBox txtconfirm;
        private Panel panel12;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        public TextBox txtusername;
    }
}