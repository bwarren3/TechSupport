namespace TechSupport.View
{
    partial class UpdateIncidentControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label lblIncidentId;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTechnician;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateOpened;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTextToAdd;
        private System.Windows.Forms.Label lblMessage;

        internal System.Windows.Forms.TextBox txtIncidentId;
        internal System.Windows.Forms.Button btnGetIncident;

        internal System.Windows.Forms.TextBox txtCustomer;
        internal System.Windows.Forms.TextBox txtProduct;
        internal System.Windows.Forms.ComboBox cboTechnician;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.TextBox txtDateOpened;
        internal System.Windows.Forms.TextBox txtDescription;
        internal System.Windows.Forms.TextBox txtTextToAdd;

        internal System.Windows.Forms.Button btnUpdateIncident;
        internal System.Windows.Forms.Button btnCloseIncident;
        internal System.Windows.Forms.Button btnClear;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            layout = new System.Windows.Forms.TableLayoutPanel();
            lblIncidentId = new System.Windows.Forms.Label();
            lblCustomer = new System.Windows.Forms.Label();
            lblProduct = new System.Windows.Forms.Label();
            lblTechnician = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblDateOpened = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblTextToAdd = new System.Windows.Forms.Label();
            lblMessage = new System.Windows.Forms.Label();

            txtIncidentId = new System.Windows.Forms.TextBox();
            btnGetIncident = new System.Windows.Forms.Button();

            txtCustomer = new System.Windows.Forms.TextBox();
            txtProduct = new System.Windows.Forms.TextBox();
            cboTechnician = new System.Windows.Forms.ComboBox();
            txtTitle = new System.Windows.Forms.TextBox();
            txtDateOpened = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtTextToAdd = new System.Windows.Forms.TextBox();

            btnUpdateIncident = new System.Windows.Forms.Button();
            btnCloseIncident = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();

            layout.SuspendLayout();
            SuspendLayout();

            layout.ColumnCount = 3;
            layout.RowCount = 10;
            layout.Dock = System.Windows.Forms.DockStyle.Fill;
            layout.Padding = new System.Windows.Forms.Padding(16);

            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));

            lblIncidentId.Text = "Incident ID:";
            lblIncidentId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblIncidentId.Dock = System.Windows.Forms.DockStyle.Fill;

            txtIncidentId.Dock = System.Windows.Forms.DockStyle.Fill;

            btnGetIncident.Text = "Get";
            btnGetIncident.Dock = System.Windows.Forms.DockStyle.Fill;

            lblCustomer.Text = "Customer:";
            lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;

            txtCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            txtCustomer.ReadOnly = true;

            lblProduct.Text = "Product:";
            lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;

            txtProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            txtProduct.ReadOnly = true;

            lblTechnician.Text = "Technician:";
            lblTechnician.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblTechnician.Dock = System.Windows.Forms.DockStyle.Fill;

            cboTechnician.Dock = System.Windows.Forms.DockStyle.Fill;
            cboTechnician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            lblTitle.Text = "Title:";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;

            txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTitle.ReadOnly = true;

            lblDateOpened.Text = "Date Opened:";
            lblDateOpened.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblDateOpened.Dock = System.Windows.Forms.DockStyle.Fill;

            txtDateOpened.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDateOpened.ReadOnly = true;

            lblDescription.Text = "Description:";
            lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;

            txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDescription.Multiline = true;
            txtDescription.ReadOnly = true;
            txtDescription.Height = 100;
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            lblTextToAdd.Text = "Text To Add:";
            lblTextToAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblTextToAdd.Dock = System.Windows.Forms.DockStyle.Fill;

            txtTextToAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            txtTextToAdd.Multiline = true;
            txtTextToAdd.Height = 80;
            txtTextToAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            btnUpdateIncident.Text = "Update";
            btnCloseIncident.Text = "Close";
            btnClear.Text = "Clear";

            lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            layout.Controls.Add(lblIncidentId, 0, 0);
            layout.Controls.Add(txtIncidentId, 1, 0);
            layout.Controls.Add(btnGetIncident, 2, 0);

            layout.Controls.Add(lblCustomer, 0, 1);
            layout.Controls.Add(txtCustomer, 1, 1);

            layout.Controls.Add(lblProduct, 0, 2);
            layout.Controls.Add(txtProduct, 1, 2);

            layout.Controls.Add(lblTechnician, 0, 3);
            layout.Controls.Add(cboTechnician, 1, 3);

            layout.Controls.Add(lblTitle, 0, 4);
            layout.Controls.Add(txtTitle, 1, 4);

            layout.Controls.Add(lblDateOpened, 0, 5);
            layout.Controls.Add(txtDateOpened, 1, 5);

            layout.Controls.Add(lblDescription, 0, 6);
            layout.Controls.Add(txtDescription, 1, 6);

            layout.Controls.Add(lblTextToAdd, 0, 7);
            layout.Controls.Add(txtTextToAdd, 1, 7);

            FlowLayoutPanel buttonPanel = new()
            {
                Dock = System.Windows.Forms.DockStyle.Left,
                FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = true,
                AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            };

            buttonPanel.Controls.Add(btnUpdateIncident);
            buttonPanel.Controls.Add(btnCloseIncident);
            buttonPanel.Controls.Add(btnClear);

            layout.Controls.Add(lblMessage, 1, 8);
            layout.Controls.Add(buttonPanel, 1, 9);

            Controls.Add(layout);

            Name = "UpdateIncidentControl";
            Size = new System.Drawing.Size(900, 550);

            layout.ResumeLayout(false);
            layout.PerformLayout();
            ResumeLayout(false);
        }
    }
}