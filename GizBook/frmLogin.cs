namespace GizBook
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            txtpassword.UseSystemPasswordChar = true;

        }



        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            frmRegister f2 = new frmRegister();
            f2.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (UserStore.UserPasswords.TryGetValue(username, out string storedPassword))
            {
                if (storedPassword == password)
                {
                    // Retrieve the full name separately
                    string fullName = UserStore.UserNames.ContainsKey(username) ? UserStore.UserNames[username] : "User";

                    MessageBox.Show("Login successful! Welcome");
                    frmHomePage dashboard = new frmHomePage();
                    dashboard.name.Text = fullName;
                    dashboard.Show();
                    this.Hide();
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

        private bool showingFirstImage = true;
        private bool passwordShown = false;

        private void panel12_Click(object sender, EventArgs e)
        {
            if (showingFirstImage)
            {
                panel12.BackgroundImage = Image.FromFile("D:\\Final Project\\Images\\login\\mdi_eye.png");
            }
            else
            {
                panel12.BackgroundImage = Image.FromFile("D:\\Final Project\\Images\\login\\btn_pw.png");
            }

            panel12.BackgroundImageLayout = ImageLayout.Center;
            showingFirstImage = !showingFirstImage;


            passwordShown = !passwordShown;
            txtpassword.UseSystemPasswordChar = !passwordShown;
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
