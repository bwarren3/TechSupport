using TechSupport.Controller;
using TechSupport.Model;

namespace TechSupport.View
{
    /// <summary>
    /// Provides the UI for retrieving, updating, and closing incidents.
    /// </summary>
    public partial class UpdateIncidentControl : UserControl
    {
        private IncidentController? controller;
        private IncidentDetail? currentIncident;
        private bool isClearing;

        private sealed class TechnicianChoice
        {
            public int? TechID { get; set; }
            public string Name { get; set; } = string.Empty;
            public override string ToString() => Name;
        }

        /// <summary>
        /// Occurs after an incident is updated or closed.
        /// </summary>
        public event EventHandler? IncidentChanged;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateIncidentControl"/> class.
        /// </summary>
        public UpdateIncidentControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes the control with the required controller.
        /// </summary>
        /// <param name="incidentController">The controller.</param>
        public void Initialize(IncidentController incidentController)
        {
            controller = incidentController;

            Load += UpdateIncidentControl_Load;
            btnGetIncident.Click += BtnGetIncident_Click;
            btnUpdateIncident.Click += BtnUpdateIncident_Click;
            btnCloseIncident.Click += BtnCloseIncident_Click;
            btnClear.Click += BtnClear_Click;
            txtIncidentId.TextChanged += TxtIncidentId_TextChanged;
        }

        private void UpdateIncidentControl_Load(object? sender, EventArgs e)
        {
            LoadTechnicians();
            ResetForm();
        }

        private void LoadTechnicians()
        {
            if (controller == null)
            {
                return;
            }

            List<TechnicianChoice> technicianChoices = new()
            {
                new TechnicianChoice { TechID = null, Name = "-- Unassigned --" }
            };

            technicianChoices.AddRange(
                controller.GetTechnicians().Select(t => new TechnicianChoice
                {
                    TechID = t.TechID,
                    Name = t.Name
                }));

            cboTechnician.DataSource = technicianChoices;
            cboTechnician.DisplayMember = "Name";
            cboTechnician.ValueMember = "TechID";
        }

        /// <summary>
        /// Resets the form to its initial state.
        /// </summary>
        public void ResetForm()
        {
            isClearing = true;

            currentIncident = null;

            txtCustomer.Text = string.Empty;
            txtProduct.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtDateOpened.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtTextToAdd.Text = string.Empty;
            lblMessage.Text = string.Empty;
            lblMessage.ForeColor = Color.Black;

            if (cboTechnician.Items.Count > 0)
            {
                cboTechnician.SelectedIndex = 0;
            }

            txtTextToAdd.Enabled = false;
            cboTechnician.Enabled = false;
            btnUpdateIncident.Enabled = false;
            btnCloseIncident.Enabled = false;

            isClearing = false;
        }

        private void TxtIncidentId_TextChanged(object? sender, EventArgs e)
        {
            if (isClearing)
            {
                return;
            }

            if (currentIncident != null)
            {
                ResetForm();
            }

            lblMessage.Text = string.Empty;
        }

        private void BtnClear_Click(object? sender, EventArgs e)
        {
            txtIncidentId.Text = string.Empty;
            ResetForm();
        }

        private void BtnGetIncident_Click(object? sender, EventArgs e)
        {
            if (controller == null)
            {
                ShowError("Controller not initialized.");
                return;
            }

            lblMessage.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtIncidentId.Text))
            {
                ShowError("Please enter an incident ID.");
                return;
            }

            if (!int.TryParse(txtIncidentId.Text.Trim(), out int incidentId))
            {
                ShowError("Incident ID must be an integer.");
                return;
            }

            IncidentDetail? incident = controller.GetIncidentById(incidentId);
            if (incident == null)
            {
                ResetForm();
                ShowError("No incident was found with that ID.");
                return;
            }

            currentIncident = incident;
            DisplayIncident(incident);
        }

        private void DisplayIncident(IncidentDetail incident)
        {
            txtCustomer.Text = incident.CustomerName;
            txtProduct.Text = incident.ProductCode;
            txtTitle.Text = incident.Title;
            txtDateOpened.Text = incident.DateOpened.ToShortDateString();
            txtDescription.Text = incident.Description;

            SelectTechnician(incident.TechID);

            if (incident.IsClosed)
            {
                cboTechnician.Enabled = false;
                txtTextToAdd.Enabled = false;
                btnUpdateIncident.Enabled = false;
                btnCloseIncident.Enabled = false;
                ShowMessage("This incident is closed and cannot be updated.");
            }
            else
            {
                cboTechnician.Enabled = true;
                txtTextToAdd.Enabled = true;
                btnUpdateIncident.Enabled = true;
                btnCloseIncident.Enabled = true;
                lblMessage.Text = string.Empty;
            }
        }

        private void SelectTechnician(int? techId)
        {
            for (int i = 0; i < cboTechnician.Items.Count; i++)
            {
                TechnicianChoice item = (TechnicianChoice)cboTechnician.Items[i]!;
                if (item.TechID == techId)
                {
                    cboTechnician.SelectedIndex = i;
                    return;
                }
            }

            cboTechnician.SelectedIndex = 0;
        }

        private void BtnUpdateIncident_Click(object? sender, EventArgs e)
        {
            if (controller == null || currentIncident == null)
            {
                ShowError("Please get an incident first.");
                return;
            }

            if (currentIncident.IsClosed)
            {
                ShowError("Closed incidents cannot be updated.");
                return;
            }

            TechnicianChoice selectedTech = (TechnicianChoice)cboTechnician.SelectedItem!;
            int? newTechId = selectedTech.TechID;
            bool techChanged = newTechId != currentIncident.TechID;

            string textToAdd = txtTextToAdd.Text.Trim();
            bool hasTextToAdd = !string.IsNullOrWhiteSpace(textToAdd);

            if (!techChanged && !hasTextToAdd)
            {
                MessageBox.Show(
                    "You must either change the technician or add text before updating.",
                    "No Changes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string updatedDescription = BuildUpdatedDescription(currentIncident.Description, textToAdd, out bool canceled);
            if (canceled)
            {
                return;
            }

            bool updated = controller.UpdateIncident(currentIncident.IncidentID, newTechId, updatedDescription);
            if (!updated)
            {
                ShowError("The incident could not be updated.");
                return;
            }

            currentIncident = controller.GetIncidentById(currentIncident.IncidentID);
            if (currentIncident != null)
            {
                DisplayIncident(currentIncident);
                txtTextToAdd.Text = string.Empty;
            }

            ShowMessage("Incident updated successfully.");
            IncidentChanged?.Invoke(this, EventArgs.Empty);
        }

        private void BtnCloseIncident_Click(object? sender, EventArgs e)
        {
            if (controller == null || currentIncident == null)
            {
                ShowError("Please get an incident first.");
                return;
            }

            if (currentIncident.IsClosed)
            {
                ShowError("This incident is already closed.");
                return;
            }

            TechnicianChoice selectedTech = (TechnicianChoice)cboTechnician.SelectedItem!;
            if (!selectedTech.TechID.HasValue)
            {
                MessageBox.Show(
                    "The incident cannot be closed because no technician is assigned.",
                    "Cannot Close Incident",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Once closed, this incident cannot be updated in this form. Do you want to close it?",
                "Confirm Close",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;
            }

            string textToAdd = txtTextToAdd.Text.Trim();
            string updatedDescription = BuildUpdatedDescription(currentIncident.Description, textToAdd, out bool canceled);
            if (canceled)
            {
                return;
            }

            bool closed = controller.CloseIncident(currentIncident.IncidentID, selectedTech.TechID.Value, updatedDescription);
            if (!closed)
            {
                ShowError("The incident could not be closed.");
                return;
            }

            currentIncident = controller.GetIncidentById(currentIncident.IncidentID);
            if (currentIncident != null)
            {
                DisplayIncident(currentIncident);
                txtTextToAdd.Text = string.Empty;
            }

            ShowMessage("Incident closed successfully.");
            IncidentChanged?.Invoke(this, EventArgs.Empty);
        }

        private string BuildUpdatedDescription(string existingDescription, string textToAdd, out bool canceled)
        {
            canceled = false;

            if (string.IsNullOrWhiteSpace(textToAdd))
            {
                return existingDescription;
            }

            if (existingDescription.Length >= 200)
            {
                MessageBox.Show(
                    "The description is already 200 characters long, so no more text can be added.",
                    "Description Full",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                canceled = true;
                return existingDescription;
            }

            string appendedLine = $"<{DateTime.Now:MM/dd/yyyy}> {textToAdd}";
            string combined = string.IsNullOrWhiteSpace(existingDescription)
                ? appendedLine
                : existingDescription + Environment.NewLine + appendedLine;

            if (combined.Length <= 200)
            {
                return combined;
            }

            DialogResult result = MessageBox.Show(
                "The updated description exceeds 200 characters and will be truncated. Do you want to continue?",
                "Truncate Description?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                canceled = true;
                return existingDescription;
            }

            return combined.Substring(0, 200);
        }

        private void ShowError(string message)
        {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = message;
        }

        private void ShowMessage(string message)
        {
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = message;
        }
    }
}