namespace TechSupport.View
{
    partial class AddIncidentControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label CustomerIdLabel;

        internal System.Windows.Forms.TextBox TitleTextBox;
        internal System.Windows.Forms.TextBox DescriptionTextBox;
        internal System.Windows.Forms.TextBox CustomerIDTextBox;

        internal System.Windows.Forms.Label TitleErrorLabel;
        internal System.Windows.Forms.Label DescriptionErrorLabel;
        internal System.Windows.Forms.Label CustomerIDErrorLabel;

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            TitleLabel = new System.Windows.Forms.Label();
            DescriptionLabel = new System.Windows.Forms.Label();
            CustomerIdLabel = new System.Windows.Forms.Label();

            TitleTextBox = new System.Windows.Forms.TextBox();
            DescriptionTextBox = new System.Windows.Forms.TextBox();
            CustomerIDTextBox = new System.Windows.Forms.TextBox();

            TitleErrorLabel = new System.Windows.Forms.Label();
            DescriptionErrorLabel = new System.Windows.Forms.Label();
            CustomerIDErrorLabel = new System.Windows.Forms.Label();

            AddButton = new System.Windows.Forms.Button();
            ClearButton = new System.Windows.Forms.Button();

            SuspendLayout();

            TitleLabel.Text = "Title:";
            TitleLabel.Location = new System.Drawing.Point(20, 20);
            TitleLabel.AutoSize = true;

            TitleTextBox.Location = new System.Drawing.Point(140, 20);
            TitleTextBox.Width = 240;
            TitleTextBox.TextChanged += TxtTitle_TextChanged;

            TitleErrorLabel.Location = new System.Drawing.Point(400, 20);
            TitleErrorLabel.AutoSize = true;

            DescriptionLabel.Text = "Description:";
            DescriptionLabel.Location = new System.Drawing.Point(20, 60);
            DescriptionLabel.AutoSize = true;

            DescriptionTextBox.Location = new System.Drawing.Point(140, 60);
            DescriptionTextBox.Width = 240;
            DescriptionTextBox.TextChanged += TxtDescription_TextChanged;

            DescriptionErrorLabel.Location = new System.Drawing.Point(400, 60);
            DescriptionErrorLabel.AutoSize = true;

            CustomerIdLabel.Text = "Customer ID:";
            CustomerIdLabel.Location = new System.Drawing.Point(20, 100);
            CustomerIdLabel.AutoSize = true;

            CustomerIDTextBox.Location = new System.Drawing.Point(140, 100);
            CustomerIDTextBox.Width = 240;
            CustomerIDTextBox.TextChanged += TxtCustomerId_TextChanged;

            CustomerIDErrorLabel.Location = new System.Drawing.Point(400, 100);
            CustomerIDErrorLabel.AutoSize = true;

            AddButton.Text = "Add";
            AddButton.Location = new System.Drawing.Point(140, 150);
            AddButton.Click += BtnAdd_Click;

            ClearButton.Text = "Clear";
            ClearButton.Location = new System.Drawing.Point(240, 150);
            ClearButton.Click += BtnClear_Click;

            Controls.Add(TitleLabel);
            Controls.Add(TitleTextBox);
            Controls.Add(TitleErrorLabel);

            Controls.Add(DescriptionLabel);
            Controls.Add(DescriptionTextBox);
            Controls.Add(DescriptionErrorLabel);

            Controls.Add(CustomerIdLabel);
            Controls.Add(CustomerIDTextBox);
            Controls.Add(CustomerIDErrorLabel);

            Controls.Add(AddButton);
            Controls.Add(ClearButton);

            Size = new System.Drawing.Size(800, 260);

            ResumeLayout(false);
        }
    }
}