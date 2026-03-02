using System.ComponentModel;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Displays all incidents in a grid.
    /// </summary>
    public partial class LoadAllIncidentsControl : UserControl
    {
        private IncidentController? incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoadAllIncidentsControl"/> class.
        /// </summary>
        public LoadAllIncidentsControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            IncidentDataGridView.AutoGenerateColumns = true;
            IncidentDataGridView.ReadOnly = true;
            IncidentDataGridView.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Initializes the control with a shared controller.
        /// </summary>
        /// <param name="controller">The incident controller.</param>
        public void Initialize(IncidentController controller)
        {
            incidentController = controller;
        }

        /// <summary>
        /// Refreshes the grid with all incidents.
        /// </summary>
        public void RefreshIncidentGrid()
        {
            if (incidentController == null)
            {
                return;
            }

            IncidentDataGridView.DataSource = null;
            IncidentDataGridView.DataSource = incidentController.GetAllIncidents();
        }
    }
}