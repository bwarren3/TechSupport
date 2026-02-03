namespace TechSupport.View
{
    partial class SearchIncidentForm
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
            customerIDLabel = new Label();
            customerIDTextBox = new TextBox();
            customerIDErroLabel = new Label();
            searchIncidentsGridView = new DataGridView();
            searchButton = new Button();
            closeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)searchIncidentsGridView).BeginInit();
            SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new Point(12, 9);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new Size(73, 15);
            customerIDLabel.TabIndex = 0;
            customerIDLabel.Text = "Customer ID";
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Location = new Point(91, 6);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(100, 23);
            customerIDTextBox.TabIndex = 1;
            // 
            // customerIDErroLabel
            // 
            customerIDErroLabel.AutoSize = true;
            customerIDErroLabel.Location = new Point(197, 9);
            customerIDErroLabel.Name = "customerIDErroLabel";
            customerIDErroLabel.Size = new Size(0, 15);
            customerIDErroLabel.TabIndex = 2;
            // 
            // searchIncidentsGridView
            // 
            searchIncidentsGridView.AllowUserToAddRows = false;
            searchIncidentsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            searchIncidentsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchIncidentsGridView.Location = new Point(12, 116);
            searchIncidentsGridView.Name = "searchIncidentsGridView";
            searchIncidentsGridView.ReadOnly = true;
            searchIncidentsGridView.Size = new Size(776, 322);
            searchIncidentsGridView.TabIndex = 3;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(10, 59);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += btnSearch_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(91, 59);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += btnClose_Click;
            // 
            // SearchIncidentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeButton);
            Controls.Add(searchButton);
            Controls.Add(searchIncidentsGridView);
            Controls.Add(customerIDErroLabel);
            Controls.Add(customerIDTextBox);
            Controls.Add(customerIDLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchIncidentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search Incidents";
            Load += SearchIncidentForm_Load;
            ((System.ComponentModel.ISupportInitialize)searchIncidentsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerIDLabel;
        private TextBox customerIDTextBox;
        private Label customerIDErroLabel;
        private DataGridView searchIncidentsGridView;
        private Button searchButton;
        private Button closeButton;
    }
}