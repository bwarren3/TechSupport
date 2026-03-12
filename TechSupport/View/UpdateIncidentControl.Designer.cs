namespace TechSupport.View
{
    partial class UpdateIncidentControl
    {
        private System.ComponentModel.IContainer components = null;

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

            SuspendLayout();

            // lblIncidentId
            lblIncidentId.AutoSize = true;
            lblIncidentId.Location = new System.Drawing.Point(20, 20);
            lblIncidentId.Name = "lblIncidentId";
            lblIncidentId.Size = new System.Drawing.Size(63, 15);
            lblIncidentId.Text = "Incident ID:";

            // txtIncidentId
            txtIncidentId.Location = new System.Drawing.Point(120, 17);
            txtIncidentId.Name = "txtIncidentId";
            txtIncidentId.Size = new System.Drawing.Size(120, 23);
            txtIncidentId.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // btnGetIncident
            btnGetIncident.Location = new System.Drawing.Point(260, 16);
            btnGetIncident.Name = "btnGetIncident";
            btnGetIncident.Size = new System.Drawing.Size(80, 25);
            btnGetIncident.Text = "Get";
            btnGetIncident.UseVisualStyleBackColor = true;
            btnGetIncident.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // lblCustomer
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new System.Drawing.Point(20, 55);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new System.Drawing.Size(62, 15);
            lblCustomer.Text = "Customer:";

            // txtCustomer
            txtCustomer.Location = new System.Drawing.Point(120, 52);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new System.Drawing.Size(620, 23);
            txtCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblProduct
            lblProduct.AutoSize = true;
            lblProduct.Location = new System.Drawing.Point(20, 90);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new System.Drawing.Size(49, 15);
            lblProduct.Text = "Product:";

            // txtProduct
            txtProduct.Location = new System.Drawing.Point(120, 87);
            txtProduct.Name = "txtProduct";
            txtProduct.ReadOnly = true;
            txtProduct.Size = new System.Drawing.Size(620, 23);
            txtProduct.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblTechnician
            lblTechnician.AutoSize = true;
            lblTechnician.Location = new System.Drawing.Point(20, 125);
            lblTechnician.Name = "lblTechnician";
            lblTechnician.Size = new System.Drawing.Size(65, 15);
            lblTechnician.Text = "Technician:";

            // cboTechnician
            cboTechnician.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboTechnician.Location = new System.Drawing.Point(120, 122);
            cboTechnician.Name = "cboTechnician";
            cboTechnician.Size = new System.Drawing.Size(620, 23);
            cboTechnician.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(20, 160);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(32, 15);
            lblTitle.Text = "Title:";

            // txtTitle
            txtTitle.Location = new System.Drawing.Point(120, 157);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new System.Drawing.Size(620, 23);
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblDateOpened
            lblDateOpened.AutoSize = true;
            lblDateOpened.Location = new System.Drawing.Point(20, 195);
            lblDateOpened.Name = "lblDateOpened";
            lblDateOpened.Size = new System.Drawing.Size(79, 15);
            lblDateOpened.Text = "Date Opened:";

            // txtDateOpened
            txtDateOpened.Location = new System.Drawing.Point(120, 192);
            txtDateOpened.Name = "txtDateOpened";
            txtDateOpened.ReadOnly = true;
            txtDateOpened.Size = new System.Drawing.Size(620, 23);
            txtDateOpened.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblDescription
            lblDescription.AutoSize = true;
            lblDescription.Location = new System.Drawing.Point(20, 230);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(70, 15);
            lblDescription.Text = "Description:";

            // txtDescription
            txtDescription.Location = new System.Drawing.Point(120, 227);
            txtDescription.Multiline = true;
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(620, 90);
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblTextToAdd
            lblTextToAdd.AutoSize = true;
            lblTextToAdd.Location = new System.Drawing.Point(20, 335);
            lblTextToAdd.Name = "lblTextToAdd";
            lblTextToAdd.Size = new System.Drawing.Size(67, 15);
            lblTextToAdd.Text = "Text To Add:";

            // txtTextToAdd
            txtTextToAdd.Location = new System.Drawing.Point(120, 332);
            txtTextToAdd.Multiline = true;
            txtTextToAdd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtTextToAdd.Name = "txtTextToAdd";
            txtTextToAdd.Size = new System.Drawing.Size(620, 70);
            txtTextToAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // lblMessage
            lblMessage.Location = new System.Drawing.Point(120, 415);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new System.Drawing.Size(620, 23);
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // btnUpdateIncident
            btnUpdateIncident.Location = new System.Drawing.Point(760, 330);
            btnUpdateIncident.Name = "btnUpdateIncident";
            btnUpdateIncident.Size = new System.Drawing.Size(90, 28);
            btnUpdateIncident.Text = "Update";
            btnUpdateIncident.UseVisualStyleBackColor = true;
            btnUpdateIncident.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // btnCloseIncident
            btnCloseIncident.Location = new System.Drawing.Point(760, 365);
            btnCloseIncident.Name = "btnCloseIncident";
            btnCloseIncident.Size = new System.Drawing.Size(90, 28);
            btnCloseIncident.Text = "Close";
            btnCloseIncident.UseVisualStyleBackColor = true;
            btnCloseIncident.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // btnClear
            btnClear.Location = new System.Drawing.Point(760, 400);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(90, 28);
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // UpdateIncidentControl
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(lblIncidentId);
            Controls.Add(txtIncidentId);
            Controls.Add(btnGetIncident);
            Controls.Add(lblCustomer);
            Controls.Add(txtCustomer);
            Controls.Add(lblProduct);
            Controls.Add(txtProduct);
            Controls.Add(lblTechnician);
            Controls.Add(cboTechnician);
            Controls.Add(lblTitle);
            Controls.Add(txtTitle);
            Controls.Add(lblDateOpened);
            Controls.Add(txtDateOpened);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblTextToAdd);
            Controls.Add(txtTextToAdd);
            Controls.Add(lblMessage);
            Controls.Add(btnUpdateIncident);
            Controls.Add(btnCloseIncident);
            Controls.Add(btnClear);
            Name = "UpdateIncidentControl";
            Size = new System.Drawing.Size(880, 470);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}