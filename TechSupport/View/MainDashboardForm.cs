using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Hosts the main application features in a tabbed dashboard.
    /// </summary>
    public partial class MainDashboardForm : Form
    {
        private readonly IncidentController incidentController;
        private readonly LoginForm loginForm;

        private readonly AddIncidentControl addIncidentControl = new AddIncidentControl();
        private readonly DisplayOpenIncidentsControl displayOpenIncidentsControl = new DisplayOpenIncidentsControl();
        private readonly UpdateIncidentControl updateIncidentControl = new UpdateIncidentControl();

        /// <summary>
        /// Gets a value indicating whether the dashboard was closed by clicking Logout.
        /// </summary>
        public bool WasLoggedOut { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainDashboardForm"/> class.
        /// </summary>
        /// <param name="loginForm">The login form that opened this dashboard.</param>
        public MainDashboardForm(LoginForm loginForm)
        {
            InitializeComponent();

            this.loginForm = loginForm;

            StartPosition = FormStartPosition.CenterScreen;

            incidentController = new IncidentController();

         
            addIncidentControl.Initialize(incidentController);
            displayOpenIncidentsControl.Initialize(incidentController);
            updateIncidentControl.Initialize(incidentController);

        
            addIncidentControl.IncidentCreated += AddIncidentControl_IncidentCreated;
            updateIncidentControl.IncidentChanged += UpdateIncidentControl_IncidentChanged;

          
            addIncidentControl.Dock = DockStyle.Fill;
            displayOpenIncidentsControl.Dock = DockStyle.Fill;
            updateIncidentControl.Dock = DockStyle.Fill;

            
            AddIncidentTab.Controls.Add(addIncidentControl);
            DisplayOpenIncidentsTab.Controls.Add(displayOpenIncidentsControl);
            UpdateIncidentTab.Controls.Add(updateIncidentControl);

            
            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            MainTabControl.MouseDown += MainTabControl_MouseDown;
        }

        private void UpdateIncidentControl_IncidentChanged(object? sender, EventArgs e)
        {
            displayOpenIncidentsControl.RefreshOpenIncidents();
            MainTabControl.SelectedTab = DisplayOpenIncidentsTab;
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
            if (MainTabControl.SelectedTab == DisplayOpenIncidentsTab)
            {
                displayOpenIncidentsControl.RefreshOpenIncidents();
            }

            if (MainTabControl.SelectedTab == UpdateIncidentTab)
            {
                updateIncidentControl.ResetForm();
            }
        }

        private void AddIncidentControl_IncidentCreated(object? sender, EventArgs e)
        {
            displayOpenIncidentsControl.RefreshOpenIncidents();
            MainTabControl.SelectedTab = DisplayOpenIncidentsTab;
        }

        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            WasLoggedOut = true;
            Close();
        }
    }
}