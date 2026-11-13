
using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class LogInForm : Form
    {
        private SupabaseService supabase = new SupabaseService();

        public LogInForm()
        {
            InitializeComponent();

            // Hide password characters
            txtPassword.PasswordChar = '*';

            // Connect buttons
            btnLogin.Click += btnLogin_Click;
            btnRegister.Click += btnRegister_Click;
        }

        // LOGIN BUTTON
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your email and password.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            btnLogin.Enabled = false;

            try
            {
                // Login using Supabase
                await supabase.LoginAsync(email, password);

                MessageBox.Show(
                    "Login successful!",
                    "Welcome",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                MainForm main = new MainForm(supabase);
                main.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login failed: " + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                btnLogin.Enabled = true;
            }
        }

        // REGISTER BUTTON
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm(this);
            register.Show();
            this.Hide();
        }
    }
}
