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

                dashboard = new MainDashboardForm(this);
                dashboard.FormClosed += Dashboard_FormClosed;

                Hide();
                dashboard.Show();
            }
            else
            {
                messageLabel.Text = "Invalid username/password";
                messageLabel.ForeColor = Color.Red;
            }
        }

        /// <summary>
        /// Returns the user to the login screen after logging out.
        /// </summary>
        public void ReturnFromLogout()
        {
            passwordTextBox.Clear();
            messageLabel.Text = string.Empty;

            Show();
            Activate();
            passwordTextBox.Focus();
        }

        /// <summary>
        /// Handles the dashboard closing behavior.
        /// If the user clicked Logout, show the login form again.
        /// Otherwise, close the hidden login form so the application exits.
        /// </summary>
        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (dashboard != null && dashboard.WasLoggedOut)
            {
                ReturnFromLogout();
                dashboard = null;
            }
            else
            {
                Close();
            }
        }

        private void ClearErrorMessage(object? sender, EventArgs e)
        {
            messageLabel.Text = string.Empty;
        }
    }
}