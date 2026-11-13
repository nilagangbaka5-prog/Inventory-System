
using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class RegisterForm : Form
    {
        private LogInForm loginForm;
        private SupabaseService supabase = new SupabaseService();

        public RegisterForm(LogInForm login)
        {
            InitializeComponent();

            loginForm = login;

            // Hide password characters
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        // REGISTER BUTTON
        private async void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check empty fields
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Check password match
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Registration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            // Check password length
            if (password.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters.",
                    "Weak Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                btnRegister.Enabled = false;
                btnRegister.Text = "REGISTERING...";

                // Register account using Supabase
                // Email is temporarily used as the profile name
                await supabase.RegisterAsync(email, password, email);

                MessageBox.Show(
                    "Account created successfully! Please check your email if confirmation is required.",
                    "Registration Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Clear fields
                txtEmail.Clear();
                txtPassword.Clear();
                txtConfirmPassword.Clear();

                // Return to Login Form
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Registration failed:\n" + ex.Message,
                    "Registration Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (!IsDisposed)
                {
                    btnRegister.Enabled = true;
                    btnRegister.Text = "REGISTER";
                }
            }
        }

        // BACK TO LOGIN BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
