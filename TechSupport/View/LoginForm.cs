namespace TechSupport.View
{
    /// <summary>
    /// Login form for the TechSupport application.
    /// </summary>
    public partial class LoginForm : Form
    {
        private MainDashboardForm? dashboard;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            AcceptButton = loginButton;

            usernameTextBox.TextChanged += ClearErrorMessage;
            passwordTextBox.TextChanged += ClearErrorMessage;

            messageLabel.Text = string.Empty;
            messageLabel.ForeColor = Color.Red;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (username == "jane" && password == "test1234")
            {
                messageLabel.Text = string.Empty;

                Hide();

                dashboard = new MainDashboardForm();
                dashboard.FormClosed += Dashboard_FormClosed;
                dashboard.Show();
            }
            else
            {
                messageLabel.Text = "Invalid username/password";
                messageLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Returns the user to the login screen and clears the password field.
        /// </summary>
        public void ReturnFromLogout()
        {
            passwordTextBox.Text = string.Empty;
            messageLabel.Text = string.Empty;
            Show();
            Activate();
            usernameTextBox.Focus();
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            passwordTextBox.Clear();

            messageLabel.Text = string.Empty;

            this.Show();
            this.Activate();
            passwordTextBox.Focus();
        }

        private void ClearErrorMessage(object? sender, EventArgs e)
        {
            messageLabel.Text = string.Empty;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}