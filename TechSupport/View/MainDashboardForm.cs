using System;
using System.Windows.Forms;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Hosts the main application features in a tabbed dashboard.
    /// </summary>
    public partial class MainDashboardForm : Form
    {
        private readonly IncidentController incidentController = new IncidentController();

        private readonly AddIncidentControl addIncidentControl = new AddIncidentControl();
        private readonly LoadAllIncidentsControl loadAllIncidentsControl = new LoadAllIncidentsControl();
        private readonly SearchIncidentControl searchIncidentControl = new SearchIncidentControl();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashboardForm"/> class.
        /// </summary>
        public MainDashboardForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            addIncidentControl.Initialize(incidentController);
            loadAllIncidentsControl.Initialize(incidentController);
            searchIncidentControl.Initialize(incidentController);

            addIncidentControl.Dock = DockStyle.Fill;
            loadAllIncidentsControl.Dock = DockStyle.Fill;
            searchIncidentControl.Dock = DockStyle.Fill;

            AddIncidentTab.Controls.Add(addIncidentControl);
            LoadAllIncidentsTab.Controls.Add(loadAllIncidentsControl);
            SearchIncidentTab.Controls.Add(searchIncidentControl);

            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
        }

        private void MainTabControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (MainTabControl.SelectedTab == LoadAllIncidentsTab)
            {
                loadAllIncidentsControl.RefreshIncidentGrid();
            }
        }
    }
}
