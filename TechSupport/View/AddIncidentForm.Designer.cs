namespace TechSupport.View
{
    partial class AddIncidentForm
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
            titleLabel = new Label();
            descriptionLabel = new Label();
            customerIDLabel = new Label();
            addButton = new Button();
            cancelButton = new Button();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            customerIDTextBox = new TextBox();
            titleErrorLabel = new Label();
            descriptionErrorLabel = new Label();
            customerIDErrorLabel = new Label();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(30, 15);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Title";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(12, 38);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(67, 15);
            descriptionLabel.TabIndex = 1;
            descriptionLabel.Text = "Description";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new Point(12, 67);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new Size(73, 15);
            customerIDLabel.TabIndex = 2;
            customerIDLabel.Text = "Customer ID";
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 96);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += btnAdd_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(93, 96);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += btnCancel_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(85, 6);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(100, 23);
            titleTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(85, 35);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(100, 23);
            descriptionTextBox.TabIndex = 6;
            // 
            // customerIDTextBox
            // 
            customerIDTextBox.Location = new Point(85, 64);
            customerIDTextBox.Name = "customerIDTextBox";
            customerIDTextBox.Size = new Size(100, 23);
            customerIDTextBox.TabIndex = 7;
            // 
            // titleErrorLabel
            // 
            titleErrorLabel.AutoSize = true;
            titleErrorLabel.Location = new Point(191, 9);
            titleErrorLabel.Name = "titleErrorLabel";
            titleErrorLabel.Size = new Size(0, 15);
            titleErrorLabel.TabIndex = 8;
            // 
            // descriptionErrorLabel
            // 
            descriptionErrorLabel.AutoSize = true;
            descriptionErrorLabel.Location = new Point(191, 38);
            descriptionErrorLabel.Name = "descriptionErrorLabel";
            descriptionErrorLabel.Size = new Size(0, 15);
            descriptionErrorLabel.TabIndex = 9;
            // 
            // customerIDErrorLabel
            // 
            customerIDErrorLabel.AutoSize = true;
            customerIDErrorLabel.Location = new Point(191, 67);
            customerIDErrorLabel.Name = "customerIDErrorLabel";
            customerIDErrorLabel.Size = new Size(0, 15);
            customerIDErrorLabel.TabIndex = 10;
            // 
            // AddIncidentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customerIDErrorLabel);
            Controls.Add(descriptionErrorLabel);
            Controls.Add(titleErrorLabel);
            Controls.Add(customerIDTextBox);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(customerIDLabel);
            Controls.Add(descriptionLabel);
            Controls.Add(titleLabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddIncidentForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Incident";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private Label descriptionLabel;
        private Label customerIDLabel;
        private Button addButton;
        private Button cancelButton;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private TextBox customerIDTextBox;
        private Label titleErrorLabel;
        private Label descriptionErrorLabel;
        private Label customerIDErrorLabel;
    }
}