namespace TechSupport.View
{
    partial class MainDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        internal System.Windows.Forms.TabControl MainTabControl;
        internal System.Windows.Forms.TabPage AddIncidentTab;
        internal System.Windows.Forms.TabPage LoadAllIncidentsTab;
        internal System.Windows.Forms.TabPage SearchIncidentTab;
        internal System.Windows.Forms.TabPage DisplayOpenIncidentsTab;
        internal System.Windows.Forms.Panel TopPanel;
        internal System.Windows.Forms.LinkLabel lnkLogout;

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
            MainTabControl = new System.Windows.Forms.TabControl();
            AddIncidentTab = new System.Windows.Forms.TabPage();
            LoadAllIncidentsTab = new System.Windows.Forms.TabPage();
            SearchIncidentTab = new System.Windows.Forms.TabPage();
            DisplayOpenIncidentsTab = new System.Windows.Forms.TabPage();
            TopPanel = new System.Windows.Forms.Panel();
            lnkLogout = new System.Windows.Forms.LinkLabel();

            MainTabControl.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();

            // 
            // TopPanel
            // 
            TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            TopPanel.Height = 32;
            TopPanel.Name = "TopPanel";

            // 
            // lnkLogout
            // 
            lnkLogout.AutoSize = true;
            lnkLogout.Name = "lnkLogout";
            lnkLogout.Text = "Logout";
            lnkLogout.TabStop = true;
            lnkLogout.Location = new System.Drawing.Point(840, 9); // adjust if needed
            lnkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogout_LinkClicked);

            TopPanel.Controls.Add(lnkLogout);

            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(AddIncidentTab);
            MainTabControl.Controls.Add(LoadAllIncidentsTab);
            MainTabControl.Controls.Add(SearchIncidentTab);
            MainTabControl.Controls.Add(DisplayOpenIncidentsTab);
            MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;

            // 
            // AddIncidentTab
            // 
            AddIncidentTab.Name = "AddIncidentTab";
            AddIncidentTab.Text = "Add Incident";
            AddIncidentTab.UseVisualStyleBackColor = true;

            // 
            // LoadAllIncidentsTab
            // 
            LoadAllIncidentsTab.Name = "LoadAllIncidentsTab";
            LoadAllIncidentsTab.Text = "Load All Incidents";
            LoadAllIncidentsTab.UseVisualStyleBackColor = true;

            // 
            // SearchIncidentTab
            // 
            SearchIncidentTab.Name = "SearchIncidentTab";
            SearchIncidentTab.Text = "Search Incident";
            SearchIncidentTab.UseVisualStyleBackColor = true;

            // 
            // DisplayOpenIncidentsTab
            // 
            DisplayOpenIncidentsTab.Name = "DisplayOpenIncidentsTab";
            DisplayOpenIncidentsTab.Text = "Display Open Incidents";
            DisplayOpenIncidentsTab.UseVisualStyleBackColor = true;

            // 
            // MainDashboardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 550);
            Controls.Add(MainTabControl);
            Controls.Add(TopPanel);
            Name = "MainDashboardForm";
            Text = "Main Dashboard";

            MainTabControl.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}