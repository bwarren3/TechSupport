using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Controller;
using TechSupport.View; 

namespace TechSupport.View
{
    /// <summary>
    /// Main form displayed after a successful login.
    /// </summary>
    public partial class MainForm : Form
    {
        private readonly LoginForm loginForm;
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of the MainForm.
        /// </summary>
        /// <param name="username">The username to display.</param>
        /// <param name="loginForm">A reference to the LoginForm instance.</param>
        public MainForm(string username, LoginForm loginForm)
        {
            InitializeComponent();

            this.loginForm = loginForm;
            this.incidentController = new IncidentController();

            this.SetUsername(username);
        }

        /// <summary>
        /// Sets the username label.
        /// </summary>
        /// <param name="username">The username.</param>
        public void SetUsername(string username)
        {
            this.mainFormUsernameLabel.Text = username;
        }

        /// <summary>
        /// Loads all incidents into the DataGridView when the form loads.
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.RefreshIncidentGrid();
        }

        /// <summary>
        /// Refreshes the incident grid by re-binding its data source.
        /// </summary>
        private void RefreshIncidentGrid()
        {
            this.incidentDataGridView.DataSource = null;
            this.incidentDataGridView.DataSource = this.incidentController.GetAllIncidents();
        }

        /// <summary>
        /// Opens the Add Incident form as a modal dialog.
        /// If the user successfully adds an incident, refresh the grid.
        /// </summary>
        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddIncidentForm(this.incidentController))
            {
                DialogResult result = addForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    this.RefreshIncidentGrid();
                }
            }
        }

        /// <summary>
        /// Opens the Search Incident form as a modal dialog.
        /// </summary>
        private void btnSearchIncident_Click(object sender, EventArgs e)
        {
            using (var searchForm = new SearchIncidentForm(this.incidentController))
            {
                searchForm.ShowDialog(this);
            }
        }

        /// <summary>
        /// Logs the user out and returns to the LoginForm.
        /// </summary>
        private void lnkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.loginForm.ReturnFromLogout();
        }

        /// <summary>
        /// Ensures the application exits when the MainForm is closed.
        /// This prevents hidden forms from keeping the process alive.
        /// </summary>
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
    }
}
