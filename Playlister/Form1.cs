namespace Playlister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Bitt" && txtPassword.Text == "Novasaar14!")
            {
                new HomeForm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username of password is incorrect!");
                txtPassword.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            }
        }

        private void lblClearFields(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void lblExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSecret(object sender, EventArgs e)
        {
            new HomeForm().Show();
            this.Hide();
        }
    }
}