namespace TechSupport.View
{
    /// <summary>
    /// Login form for the TechSupport application.
    /// </summary>
    public partial class LoginForm : Form
    {
        private MainForm? mainForm;

        /// <summary>
        /// Initializes a new instance of the LoginForm.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();

            // UX polish
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = this.loginButton;

            // Clear error when user starts typing again
            this.usernameTextBox.TextChanged += ClearErrorMessage;
            this.passwordTextBox.TextChanged += ClearErrorMessage;

            this.messageLabel.Text = string.Empty;
            this.messageLabel.ForeColor = Color.Red;
        }

        /// <summary>
        /// Handles the Login button click.
        /// Validates credentials and opens the MainForm.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;

            // Case-sensitive check per assignment
            if (username == "jane" && password == "test1234")
            {
                this.messageLabel.Text = string.Empty;

                // Ensure only one MainForm instance exists
                if (this.mainForm == null || this.mainForm.IsDisposed)
                {
                    this.mainForm = new MainForm(username, this);

                    // If MainForm is closed via ❌, exit the app
                    this.mainForm.FormClosed += (_, __) => Application.Exit();
                }
                else
                {
                    // Update username if reusing the instance
                    this.mainForm.SetUsername(username);
                }

                this.Hide();
                this.mainForm.Show();
            }
            else
            {
                this.messageLabel.Text = "Invalid username/password";
                this.messageLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Clears the error message when the user edits input fields.
        /// </summary>
        private void ClearErrorMessage(object? sender, EventArgs e)
        {
            this.messageLabel.Text = string.Empty;
        }

        /// <summary>
        /// Called by MainForm when the user logs out.
        /// Returns the user to the LoginForm.
        /// </summary>
        public void ReturnFromLogout()
        {
            this.passwordTextBox.Text = string.Empty;
            this.messageLabel.Text = string.Empty;

            this.Show();
            this.Activate();
            this.usernameTextBox.Focus();
        }

        /// <summary>
        /// Ensures the application exits when the LoginForm is closed.
        /// </summary>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}
