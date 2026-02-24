namespace TechSupport.View
{
    partial class MainForm
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
            mainFormLogoutLinkLabel = new LinkLabel();
            mainFormUsernameLabel = new Label();
            addIncidentButton = new Button();
            searchIncidentButton = new Button();
            incidentDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)incidentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainFormLogoutLinkLabel
            // 
            mainFormLogoutLinkLabel.AutoSize = true;
            mainFormLogoutLinkLabel.Dock = DockStyle.Right;
            mainFormLogoutLinkLabel.Location = new Point(755, 0);
            mainFormLogoutLinkLabel.Name = "mainFormLogoutLinkLabel";
            mainFormLogoutLinkLabel.Size = new Size(45, 15);
            mainFormLogoutLinkLabel.TabIndex = 1;
            mainFormLogoutLinkLabel.TabStop = true;
            mainFormLogoutLinkLabel.Text = "Logout";
            mainFormLogoutLinkLabel.LinkClicked += LnkLogout_LinkClicked;
            // 
            // mainFormUsernameLabel
            // 
            mainFormUsernameLabel.AutoSize = true;
            mainFormUsernameLabel.Dock = DockStyle.Right;
            mainFormUsernameLabel.Location = new Point(755, 0);
            mainFormUsernameLabel.Name = "mainFormUsernameLabel";
            mainFormUsernameLabel.Size = new Size(0, 15);
            mainFormUsernameLabel.TabIndex = 2;
            // 
            // addIncidentButton
            // 
            addIncidentButton.Location = new Point(0, 0);
            addIncidentButton.Name = "addIncidentButton";
            addIncidentButton.Size = new Size(100, 23);
            addIncidentButton.TabIndex = 3;
            addIncidentButton.Text = "Add Incident";
            addIncidentButton.UseVisualStyleBackColor = true;
            addIncidentButton.Click += BtnAddIncident_Click;
            // 
            // searchIncidentButton
            // 
            searchIncidentButton.Location = new Point(106, 0);
            searchIncidentButton.Name = "searchIncidentButton";
            searchIncidentButton.Size = new Size(100, 23);
            searchIncidentButton.TabIndex = 4;
            searchIncidentButton.Text = "Search Incident";
            searchIncidentButton.UseVisualStyleBackColor = true;
            searchIncidentButton.Click += BtnSearchIncident_Click;
            // 
            // incidentDataGridView
            // 
            incidentDataGridView.AllowUserToAddRows = false;
            incidentDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            incidentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            incidentDataGridView.Location = new Point(12, 29);
            incidentDataGridView.Name = "incidentDataGridView";
            incidentDataGridView.ReadOnly = true;
            incidentDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            incidentDataGridView.Size = new Size(703, 391);
            incidentDataGridView.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(incidentDataGridView);
            Controls.Add(searchIncidentButton);
            Controls.Add(addIncidentButton);
            Controls.Add(mainFormUsernameLabel);
            Controls.Add(mainFormLogoutLinkLabel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TechSupport";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)incidentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel mainFormLogoutLinkLabel;
        private Label mainFormUsernameLabel;
        private Button addIncidentButton;
        private Button searchIncidentButton;
        private DataGridView incidentDataGridView;
    }
}