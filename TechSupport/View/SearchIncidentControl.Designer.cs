namespace TechSupport.View
{
    partial class SearchIncidentControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label CustomerIdLabel;
        internal System.Windows.Forms.TextBox CustomerIDTextBox;
        internal System.Windows.Forms.Label CustomerIDErrorLabel;

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ClearButton;

        internal System.Windows.Forms.DataGridView ResultsGridView;

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
            CustomerIdLabel = new System.Windows.Forms.Label();
            CustomerIDTextBox = new System.Windows.Forms.TextBox();
            CustomerIDErrorLabel = new System.Windows.Forms.Label();

            SearchButton = new System.Windows.Forms.Button();
            ClearButton = new System.Windows.Forms.Button();

            ResultsGridView = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)ResultsGridView).BeginInit();
            SuspendLayout();

            CustomerIdLabel.Text = "Customer ID:";
            CustomerIdLabel.Location = new System.Drawing.Point(20, 20);
            CustomerIdLabel.AutoSize = true;

            CustomerIDTextBox.Location = new System.Drawing.Point(140, 20);
            CustomerIDTextBox.Width = 200;
            CustomerIDTextBox.TextChanged += TxtCustomerId_TextChanged;

            CustomerIDErrorLabel.Location = new System.Drawing.Point(360, 20);
            CustomerIDErrorLabel.AutoSize = true;

            SearchButton.Text = "Search";
            SearchButton.Location = new System.Drawing.Point(140, 55);
            SearchButton.Click += BtnSearch_Click;

            ClearButton.Text = "Clear";
            ClearButton.Location = new System.Drawing.Point(230, 55);
            ClearButton.Click += BtnClear_Click;

            ResultsGridView.Location = new System.Drawing.Point(20, 100);
            ResultsGridView.Size = new System.Drawing.Size(840, 360);
            ResultsGridView.Name = "ResultsGridView";

            Controls.Add(CustomerIdLabel);
            Controls.Add(CustomerIDTextBox);
            Controls.Add(CustomerIDErrorLabel);
            Controls.Add(SearchButton);
            Controls.Add(ClearButton);
            Controls.Add(ResultsGridView);

            Size = new System.Drawing.Size(900, 550);

            ((System.ComponentModel.ISupportInitialize)ResultsGridView).EndInit();
            ResumeLayout(false);
        }
    }
}