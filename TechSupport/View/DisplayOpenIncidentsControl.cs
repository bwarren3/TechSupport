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
        /// Refreshes the open incidents list from the database.
        /// </summary>
        public void RefreshOpenIncidents()
        {
            var items = incidentController.GetOpenIncidents();

            OpenIncidentsListView.BeginUpdate();
            OpenIncidentsListView.Items.Clear();

            foreach (OpenIncident incident in items)
            {
                ListViewItem row = new ListViewItem(incident.ProductCode);

                row.SubItems.Add(incident.DateOpened.ToShortDateString());
                row.SubItems.Add(incident.CustomerName);
                row.SubItems.Add(incident.TechnicianName);
                row.SubItems.Add(incident.Title);

                OpenIncidentsListView.Items.Add(row);
            }

            OpenIncidentsListView.EndUpdate();
        }
    }
}