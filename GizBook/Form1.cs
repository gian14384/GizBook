namespace GizBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtpassword.UseSystemPasswordChar = true;
        }

        protected override CreateParams CreateParams

        {
            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (UserStore.Users.TryGetValue(username, out string storedPassword))
            {
                if (storedPassword == password)
                {
                    MessageBox.Show("Login successful!");
                    // Proceed to next form or main application
                }
                else
                {
                    MessageBox.Show("Incorrect password.");
                }
            }
            else
            {
                MessageBox.Show("Username not found.");
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (txtpassword.UseSystemPasswordChar)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
