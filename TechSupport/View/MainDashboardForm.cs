using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Hosts the main application features in a tabbed dashboard.
    /// </summary>
    public partial class MainDashboardForm : Form
    {
        private readonly IncidentController incidentController;

        private readonly AddIncidentControl addIncidentControl = new AddIncidentControl();
        private readonly LoadAllIncidentsControl loadAllIncidentsControl = new LoadAllIncidentsControl();
        private readonly SearchIncidentControl searchIncidentControl = new SearchIncidentControl();
        private readonly DisplayOpenIncidentsControl displayOpenIncidentsControl = new DisplayOpenIncidentsControl();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashboardForm"/> class.
        /// </summary>
        public MainDashboardForm()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            incidentController = new IncidentController();

            addIncidentControl.Initialize(incidentController);
            loadAllIncidentsControl.Initialize(incidentController);
            searchIncidentControl.Initialize(incidentController);
            displayOpenIncidentsControl.Initialize(incidentController);

            addIncidentControl.IncidentCreated += AddIncidentControl_IncidentCreated;

            addIncidentControl.Dock = DockStyle.Fill;
            loadAllIncidentsControl.Dock = DockStyle.Fill;
            searchIncidentControl.Dock = DockStyle.Fill;
            displayOpenIncidentsControl.Dock = DockStyle.Fill;

            AddIncidentTab.Controls.Add(addIncidentControl);
            LoadAllIncidentsTab.Controls.Add(loadAllIncidentsControl);
            SearchIncidentTab.Controls.Add(searchIncidentControl);
            DisplayOpenIncidentsTab.Controls.Add(displayOpenIncidentsControl);

            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            MainTabControl.MouseDown += MainTabControl_MouseDown;
        }

        private void MainTabControl_MouseDown(object? sender, MouseEventArgs e)
        {
            for (int i = 0; i < MainTabControl.TabCount; i++)
            {
                if (MainTabControl.GetTabRect(i).Contains(e.Location))
                {
                    if (MainTabControl.TabPages[i] == DisplayOpenIncidentsTab)
                    {
                        displayOpenIncidentsControl.RefreshOpenIncidents();
                    }
                    break;
                }
            }
        }

        private void MainTabControl_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (MainTabControl.SelectedTab == LoadAllIncidentsTab)
            {
                loadAllIncidentsControl.RefreshIncidentGrid();
            }

            if (MainTabControl.SelectedTab == DisplayOpenIncidentsTab)
            {
                displayOpenIncidentsControl.RefreshOpenIncidents();
            }
        }

        private void AddIncidentControl_IncidentCreated(object? sender, EventArgs e)
        {

            displayOpenIncidentsControl.RefreshOpenIncidents();


            MainTabControl.SelectedTab = DisplayOpenIncidentsTab;
        }
        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();

            this.Close();
        }
    }
}