namespace GizBook
{
    partial class frmFAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFAQ));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btndropdown1 = new Panel();
            paneldropdown1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(88, 1025);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(82, 68);
            panel2.TabIndex = 0;
            panel2.Click += panel2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new Point(688, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(123, 46);
            panel3.TabIndex = 1;
            // 
            // btndropdown1
            // 
            btndropdown1.BackColor = Color.Transparent;
            btndropdown1.BackgroundImage = (Image)resources.GetObject("btndropdown1.BackgroundImage");
            btndropdown1.BackgroundImageLayout = ImageLayout.Center;
            btndropdown1.Location = new Point(122, 151);
            btndropdown1.Name = "btndropdown1";
            btndropdown1.Size = new Size(1266, 85);
            btndropdown1.TabIndex = 2;
            btndropdown1.Click += btndropdown1_Click;
            btndropdown1.Paint += btndropdown1_Paint;
            // 
            // paneldropdown1
            // 
            paneldropdown1.BackColor = Color.Transparent;
            paneldropdown1.BackgroundImage = (Image)resources.GetObject("paneldropdown1.BackgroundImage");
            paneldropdown1.BackgroundImageLayout = ImageLayout.Center;
            paneldropdown1.Location = new Point(122, 242);
            paneldropdown1.Name = "paneldropdown1";
            paneldropdown1.Size = new Size(1164, 85);
            paneldropdown1.TabIndex = 3;
            paneldropdown1.Visible = false;
            // 
            // frmFAQ
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1440, 1024);
            Controls.Add(paneldropdown1);
            Controls.Add(btndropdown1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFAQ";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFAQ";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel btndropdown1;
        private Panel paneldropdown1;
    }
}