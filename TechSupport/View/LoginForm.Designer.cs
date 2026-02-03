namespace TechSupport.View
{
    partial class LoginForm
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
            loginTableLayoutPanel = new TableLayoutPanel();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            usernameLabel = new Label();
            usernameTextBox = new TextBox();
            messageLabel = new Label();
            loginButton = new Button();
            loginTableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginTableLayoutPanel
            // 
            loginTableLayoutPanel.ColumnCount = 3;
            loginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            loginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            loginTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            loginTableLayoutPanel.Controls.Add(passwordTextBox, 2, 2);
            loginTableLayoutPanel.Controls.Add(passwordLabel, 1, 2);
            loginTableLayoutPanel.Controls.Add(usernameLabel, 1, 1);
            loginTableLayoutPanel.Controls.Add(usernameTextBox, 2, 1);
            loginTableLayoutPanel.Controls.Add(messageLabel, 2, 4);
            loginTableLayoutPanel.Controls.Add(loginButton, 1, 5);
            loginTableLayoutPanel.Dock = DockStyle.Fill;
            loginTableLayoutPanel.Location = new Point(0, 0);
            loginTableLayoutPanel.Name = "loginTableLayoutPanel";
            loginTableLayoutPanel.RowCount = 7;
            loginTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 49.881237F));
            loginTableLayoutPanel.RowStyles.Add(new RowStyle());
            loginTableLayoutPanel.RowStyles.Add(new RowStyle());
            loginTableLayoutPanel.RowStyles.Add(new RowStyle());
            loginTableLayoutPanel.RowStyles.Add(new RowStyle());
            loginTableLayoutPanel.RowStyles.Add(new RowStyle());
            loginTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.118763F));
            loginTableLayoutPanel.Size = new Size(800, 450);
            loginTableLayoutPanel.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left;
            passwordTextBox.Location = new Point(443, 205);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextChanged += ClearErrorMessage;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.None;
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(371, 209);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.Anchor = AnchorStyles.None;
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(369, 180);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(60, 15);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username";
            usernameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(443, 176);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.TextChanged += ClearErrorMessage;
            // 
            // messageLabel
            // 
            messageLabel.Anchor = AnchorStyles.Left;
            messageLabel.AutoSize = true;
            messageLabel.ForeColor = Color.Red;
            messageLabel.Location = new Point(443, 231);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(0, 15);
            messageLabel.TabIndex = 4;
            messageLabel.UseWaitCursor = true;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(362, 249);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(75, 23);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginTableLayoutPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechSupport - Login";
            loginTableLayoutPanel.ResumeLayout(false);
            loginTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel loginTableLayoutPanel;
        private Label usernameLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Label messageLabel;
        private Button loginButton;
    }
}