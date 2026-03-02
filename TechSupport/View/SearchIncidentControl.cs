using System.ComponentModel;
using TechSupport.Controller;

namespace TechSupport.View
{
    /// <summary>
    /// Provides UI for searching incidents by customer id.
    /// </summary>
    public partial class SearchIncidentControl : UserControl
    {
        private IncidentController? incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchIncidentControl"/> class.
        /// </summary>
        public SearchIncidentControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            CustomerIDErrorLabel.Text = "";
            CustomerIDErrorLabel.ForeColor = System.Drawing.Color.Red;

            ResultsGridView.AutoGenerateColumns = true;
            ResultsGridView.ReadOnly = true;
            ResultsGridView.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Initializes the control with a shared controller.
        /// </summary>
        /// <param name="controller">The incident controller.</param>
        public void Initialize(IncidentController controller)
        {
            incidentController = controller;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (incidentController == null)
            {
                MessageBox.Show("Controller is not initialized.");
                return;
            }

            CustomerIDErrorLabel.Text = "";

            if (!int.TryParse(CustomerIDTextBox.Text.Trim(), out int customerId))
            {
                CustomerIDErrorLabel.Text = "Customer ID must be a number.";
                ResultsGridView.DataSource = null;
                return;
            }

            if (customerId <= 0)
            {
                CustomerIDErrorLabel.Text = "Customer ID must be positive.";
                ResultsGridView.DataSource = null;
                return;
            }

            ResultsGridView.DataSource = null;
            ResultsGridView.DataSource = incidentController.SearchIncidentsByCustomerId(customerId);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CustomerIDTextBox.Text = "";
            CustomerIDErrorLabel.Text = "";
            ResultsGridView.DataSource = null;
            CustomerIDTextBox.Focus();
        }

        private void TxtCustomerId_TextChanged(object sender, EventArgs e)
        {
            CustomerIDErrorLabel.Text = "";
        }
    }
}