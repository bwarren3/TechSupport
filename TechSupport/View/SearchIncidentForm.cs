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

namespace TechSupport.View
{
    /// <summary>
    /// Modal form that allows the user to search incidents by customer ID.
    /// </summary>
    public partial class SearchIncidentForm : Form
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of the SearchIncidentForm.
        /// </summary>
        /// <param name="incidentController">Controller used to search incidents.</param>
        public SearchIncidentForm(IncidentController incidentController)
        {
            InitializeComponent();
            this.incidentController = incidentController;

            this.StartPosition = FormStartPosition.CenterParent;

            // Optional: Enter triggers Search, Esc closes
            this.AcceptButton = this.searchButton;
            this.CancelButton = this.closeButton;

            this.customerIDErroLabel.ForeColor = Color.Red;
            this.customerIDErroLabel.Text = "";
        }

        /// <summary>
        /// Ensures the results grid is empty when the form loads.
        /// </summary>
        private void SearchIncidentForm_Load(object sender, EventArgs e)
        {
            this.searchIncidentsGridView.DataSource = null;
        }

        /// <summary>
        /// Searches incidents by customer ID and displays results on this form.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.customerIDErroLabel.Text = "";

            if (!int.TryParse(this.customerIDTextBox.Text.Trim(), out int customerId))
            {
                this.customerIDErroLabel.Text = "Customer ID must be an integer.";
                this.searchIncidentsGridView.DataSource = null;
                return;
            }

            if (customerId <= 0)
            {
                this.customerIDErroLabel.Text = "Customer ID must be positive.";
                this.searchIncidentsGridView.DataSource = null;
                return;
            }

            var results = this.incidentController.SearchIncidentsByCustomerId(customerId);

            this.searchIncidentsGridView.DataSource = null;
            this.searchIncidentsGridView.DataSource = results;
        }

        /// <summary>
        /// Closes the search form.
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            this.customerIDErroLabel.Text = "";
        }
    }
}
