using System.ComponentModel;
using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Provides UI for adding an incident.
    /// </summary>
    public partial class AddIncidentControl : UserControl
    {
        private IncidentController? incidentController;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddIncidentControl"/> class.
        /// </summary>
        public AddIncidentControl()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return;
            }

            ClearAllErrors();
        }

        /// <summary>
        /// Initializes the control with a shared controller.
        /// </summary>
        /// <param name="controller">The incident controller.</param>
        public void Initialize(IncidentController controller)
        {
            incidentController = controller;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (incidentController == null)
            {
                MessageBox.Show("Controller is not initialized.");
                return;
            }

            ClearAllErrors();

            bool isValid = true;

            string title = TitleTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                TitleErrorLabel.Text = "Title is required.";
                isValid = false;
            }

            string description = DescriptionTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(description))
            {
                DescriptionErrorLabel.Text = "Description is required.";
                isValid = false;
            }

            if (!int.TryParse(CustomerIDTextBox.Text.Trim(), out int customerId))
            {
                CustomerIDErrorLabel.Text = "Customer ID must be a number.";
                isValid = false;
            }
            else if (customerId <= 0)
            {
                CustomerIDErrorLabel.Text = "Customer ID must be positive.";
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            Incident incident = new Incident
            {
                Title = title,
                Description = description,
                CustomerId = customerId
            };

            incidentController.AddIncident(incident);

            MessageBox.Show("Incident added.");

            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CustomerIDTextBox.Text = "";
            TitleTextBox.Focus();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TitleTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CustomerIDTextBox.Text = "";
            ClearAllErrors();
            TitleTextBox.Focus();
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            TitleErrorLabel.Text = "";
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            DescriptionErrorLabel.Text = "";
        }

        private void TxtCustomerId_TextChanged(object sender, EventArgs e)
        {
            CustomerIDErrorLabel.Text = "";
        }

        private void ClearAllErrors()
        {
            TitleErrorLabel.Text = "";
            DescriptionErrorLabel.Text = "";
            CustomerIDErrorLabel.Text = "";

            TitleErrorLabel.ForeColor = System.Drawing.Color.Red;
            DescriptionErrorLabel.ForeColor = System.Drawing.Color.Red;
            CustomerIDErrorLabel.ForeColor = System.Drawing.Color.Red;
        }
    }
}