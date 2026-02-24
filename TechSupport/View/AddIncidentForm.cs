using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Modal form that allows the user to add a new incident.
    /// </summary>
    public partial class AddIncidentForm : Form
    {
        private readonly IncidentController incidentController;

        /// <summary>
        /// Initializes a new instance of the AddIncidentForm.
        /// </summary>
        /// <param name="incidentController">Controller used to add incidents.</param>
        public AddIncidentForm(IncidentController incidentController)
        {
            InitializeComponent();
            this.incidentController = incidentController;

            this.StartPosition = FormStartPosition.CenterParent;

            // Optional polish: Enter triggers Add, Esc triggers Cancel
            this.AcceptButton = this.addButton;
            this.CancelButton = this.cancelButton;

            ClearAllErrors();
        }

        /// <summary>
        /// Handles Add button click. Validates and adds the incident.
        /// </summary>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearAllErrors();

            bool isValid = true;

            string title = this.titleTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                this.titleErrorLabel.Text = "Title is required.";
                isValid = false;
            }

            string description = this.descriptionLabel.Text.Trim();
            if (string.IsNullOrWhiteSpace(description))
            {
                this.descriptionErrorLabel.Text = "Description is required.";
                isValid = false;
            }

            if (!int.TryParse(this.customerIDTextBox.Text.Trim(), out int customerId))
            {
                this.customerIDErrorLabel.Text = "Customer ID must be an integer.";
                isValid = false;
            }
            else if (customerId <= 0)
            {
                this.customerIDErrorLabel.Text = "Customer ID must be positive.";
                isValid = false;
            }

            if (!isValid)
            {
                return;
            }

            var incident = new Incident
            {
                Title = title,
                Description = description,
                CustomerId = customerId
            };

            this.incidentController.AddIncident(incident);

            // Tell MainForm: success → refresh grid
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Handles Cancel button click. Closes without adding.
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        /// <summary>
        /// Clears all error labels.
        /// </summary>
        private void ClearAllErrors()
        {
            this.titleErrorLabel.Text = "";
            this.descriptionErrorLabel.Text = "";
            this.customerIDErrorLabel.Text = "";

            this.titleErrorLabel.ForeColor = Color.Red;
            this.descriptionErrorLabel.ForeColor = Color.Red;
            this.customerIDErrorLabel.ForeColor = Color.Red;
        }

        private void TxtTitle_TextChanged(object sender, EventArgs e)
        {
            this.titleErrorLabel.Text = "";
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            this.descriptionErrorLabel.Text = "";
        }

        private void TxtCustomerId_TextChanged(object sender, EventArgs e)
        {
            this.customerIDErrorLabel.Text = "";
        }
    }
}
