using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Displays open incidents from the database in a ListView.
    /// </summary>
    public partial class DisplayOpenIncidentsControl : UserControl
    {
        private IncidentController? incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayOpenIncidentsControl"/> class.
        /// </summary>
        public DisplayOpenIncidentsControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            OpenIncidentsListView.View = System.Windows.Forms.View.Details;
            OpenIncidentsListView.FullRowSelect = true;
            OpenIncidentsListView.GridLines = true;
        }

        /// <summary>
        /// Initializes the control with a shared controller instance.
        /// </summary>
        /// <param name="controller">The incident controller.</param>
        public void Initialize(IncidentController controller)
        {
            incidentController = controller;
        }

        /// <summary>
        /// Refreshes the ListView with current open incidents from the database.
        /// </summary>
        public void RefreshOpenIncidents()
        {
            if (incidentController == null)
            {
                return;
            }

            List<OpenIncident> items;
            try
            {
                items = incidentController.GetOpenIncidents();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load open incidents.\n{ex.Message}");
                return;
            }

            OpenIncidentsListView.BeginUpdate();
            OpenIncidentsListView.Items.Clear();

            foreach (OpenIncident incident in items)
            {
                ListViewItem row = new(incident.IncidentId.ToString());
                row.SubItems.Add(incident.CustomerName);
                row.SubItems.Add(incident.ProductName);
                row.SubItems.Add(incident.DateOpened.ToString("d"));
                row.SubItems.Add(incident.TechnicianName);
                OpenIncidentsListView.Items.Add(row);
            }

            OpenIncidentsListView.EndUpdate();
        }
    }
}