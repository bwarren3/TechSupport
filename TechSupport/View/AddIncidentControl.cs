using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    public partial class AddIncidentControl : UserControl
    {
        private IncidentController? controller;
        private bool eventsWired = false;

        public event EventHandler? IncidentCreated;

        public AddIncidentControl()
        {
            InitializeComponent();
        }

        
        public void Initialize(IncidentController incidentController)
        {
            controller = incidentController;

            
            if (!eventsWired)
            {
                this.Load += AddIncidentControl_Load;
                btnCreateIncident.Click += BtnCreateIncident_Click;
                btnClear.Click += BtnClear_Click;
                eventsWired = true;
            }
        }

       
        public void ResetForTabEntry()
        {
            ResetForm(keepSelections: true);
        }

        private void AddIncidentControl_Load(object? sender, EventArgs e)
        {
            LoadComboBoxes();
            ResetForm(keepSelections: false);
        }

        private void LoadComboBoxes()
        {
            if (controller == null) return;

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

        private void ResetForm(bool keepSelections)
        {
            lblMessage.Text = "";
            lblMessage.ForeColor = System.Drawing.Color.Black;

            txtTitle.Text = "";
            txtDescription.Text = "";

            if (!keepSelections)
            {
                if (cboCustomer.Items.Count > 0) cboCustomer.SelectedIndex = 0;
                if (cboProduct.Items.Count > 0) cboProduct.SelectedIndex = 0;
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

                lblMessage.ForeColor = System.Drawing.Color.Green;
                lblMessage.Text = "Incident created successfully.";

               
                ResetForm(keepSelections: true);

                
                IncidentCreated?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                ShowError("Error creating incident: " + ex.Message);
            }
        }

        private void ShowError(string message)
        {
            lblMessage.ForeColor = System.Drawing.Color.Red;
            lblMessage.Text = message;
        }
    }
}