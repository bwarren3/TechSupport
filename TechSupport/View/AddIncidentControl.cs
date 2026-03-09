using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Provides the UI for creating a new incident.
    /// </summary>
    public partial class AddIncidentControl : UserControl
    {
        private IncidentController? controller;
        private bool eventsWired = false;

        /// <summary>
        /// Occurs after an incident is successfully created.
        /// </summary>
        public event EventHandler? IncidentCreated;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddIncidentControl"/> class.
        /// </summary>
        public AddIncidentControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the control with the required controller.
        /// </summary>
        /// <param name="incidentController">The controller used to load and create incidents.</param>
        public void Initialize(IncidentController incidentController)
        {
            controller = incidentController;

            if (!eventsWired)
            {
                Load += AddIncidentControl_Load;
                btnCreateIncident.Click += BtnCreateIncident_Click;
                btnClear.Click += BtnClear_Click;
                eventsWired = true;
            }
        }

        /// <summary>
        /// Resets the form when the user navigates back to the tab.
        /// </summary>
        public void ResetForTabEntry()
        {
            ResetForm(keepSelections: true);
        }

        private void AddIncidentControl_Load(object? sender, EventArgs e)
        {
            LoadComboBoxes();
            ResetForm(keepSelections: false);
        }

        /// <summary>
        /// Loads the customer and product combo boxes.
        /// </summary>
        private void LoadComboBoxes()
        {
            if (controller == null)
            {
                return;
            }

            var customers = controller.GetCustomers();
            var products = controller.GetProducts();

            cboCustomer.DataSource = null;
            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = "Name";
            cboCustomer.ValueMember = "CustomerID";

            cboProduct.DataSource = null;
            cboProduct.DataSource = products;
            cboProduct.DisplayMember = "Name";
            cboProduct.ValueMember = "ProductCode";
        }

        /// <summary>
        /// Resets the input controls.
        /// </summary>
        /// <param name="keepSelections">True to keep the selected customer and product; otherwise false.</param>
        private void ResetForm(bool keepSelections)
        {
            lblMessage.Text = string.Empty;
            lblMessage.ForeColor = Color.Black;

            txtTitle.Text = string.Empty;
            txtDescription.Text = string.Empty;

            if (!keepSelections)
            {
                if (cboCustomer.Items.Count > 0)
                {
                    cboCustomer.SelectedIndex = 0;
                }

                if (cboProduct.Items.Count > 0)
                {
                    cboProduct.SelectedIndex = 0;
                }
            }
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            ResetForm(keepSelections: true);
        }

        private void BtnCreateIncident_Click(object? sender, EventArgs e)
        {
            if (controller == null)
            {
                ShowError("Controller not initialized.");
                return;
            }

            if (cboCustomer.SelectedItem is not Customer selectedCustomer ||
                cboProduct.SelectedItem is not Product selectedProduct)
            {
                ShowError("Please select a customer and a product.");
                return;
            }

            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                ShowError("Title and Description are required.");
                return;
            }

            bool hasRegistration = controller.RegistrationExists(selectedCustomer.CustomerID, selectedProduct.ProductCode);
            if (!hasRegistration)
            {
                ShowError("No registration is associated with the selected product for this customer.");
                return;
            }

            try
            {
                bool created = controller.CreateIncident(
                    selectedCustomer.CustomerID,
                    selectedProduct.ProductCode,
                    title,
                    description);

                if (!created)
                {
                    ShowError("Incident was not created.");
                    return;
                }

                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Incident created successfully.";

                ResetForm(keepSelections: true);
                IncidentCreated?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("Error creating incident: " + ex.Message);
            }
        }

        /// <summary>
        /// Displays an error message to the user.
        /// </summary>
        /// <param name="message">The message to display.</param>
        private void ShowError(string message)
        {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = message;
        }
    }
}