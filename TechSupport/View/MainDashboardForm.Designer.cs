namespace TechSupport.View
{
    partial class MainDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        internal System.Windows.Forms.TabControl MainTabControl;
        internal System.Windows.Forms.TabPage AddIncidentTab;
        internal System.Windows.Forms.TabPage LoadAllIncidentsTab;
        internal System.Windows.Forms.TabPage SearchIncidentTab;

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

            MainTabControl.SuspendLayout();
            SuspendLayout();

            MainTabControl.Controls.Add(AddIncidentTab);
            MainTabControl.Controls.Add(LoadAllIncidentsTab);
            MainTabControl.Controls.Add(SearchIncidentTab);
            MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;

            AddIncidentTab.Name = "AddIncidentTab";
            AddIncidentTab.Text = "Add Incident";
            AddIncidentTab.UseVisualStyleBackColor = true;

            LoadAllIncidentsTab.Name = "LoadAllIncidentsTab";
            LoadAllIncidentsTab.Text = "Load All Incidents";
            LoadAllIncidentsTab.UseVisualStyleBackColor = true;

            SearchIncidentTab.Name = "SearchIncidentTab";
            SearchIncidentTab.Text = "Search Incident";
            SearchIncidentTab.UseVisualStyleBackColor = true;

            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(900, 550);
            Controls.Add(MainTabControl);
            Name = "MainDashboardForm";
            Text = "Main Dashboard";

            MainTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}