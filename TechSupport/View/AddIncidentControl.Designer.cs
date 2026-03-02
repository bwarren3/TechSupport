namespace TechSupport.View
{
    partial class AddIncidentControl
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;

        internal System.Windows.Forms.ComboBox cboCustomer;
        internal System.Windows.Forms.ComboBox cboProduct;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.TextBox txtDescription;

        internal System.Windows.Forms.Button btnCreateIncident;
        internal System.Windows.Forms.Button btnClear;

        internal System.Windows.Forms.Label lblMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            layout = new System.Windows.Forms.TableLayoutPanel();
            lblCustomer = new System.Windows.Forms.Label();
            lblProduct = new System.Windows.Forms.Label();
            lblTitle = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();

            cboCustomer = new System.Windows.Forms.ComboBox();
            cboProduct = new System.Windows.Forms.ComboBox();
            txtTitle = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();

            btnCreateIncident = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();

            lblMessage = new System.Windows.Forms.Label();

            SuspendLayout();

            
            layout.ColumnCount = 2;
            layout.RowCount = 7;
            layout.Dock = System.Windows.Forms.DockStyle.Top;
            layout.Padding = new System.Windows.Forms.Padding(16);
            layout.AutoSize = true;
            layout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));

            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F)); 
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F)); 
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F)); 
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F)); 
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F)); 
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F)); 
            layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F)); 

            lblCustomer.Text = "Customer:";
            lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblCustomer.Dock = System.Windows.Forms.DockStyle.Fill;

            
            cboCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

             
            lblProduct.Text = "Product:";
            lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblProduct.Dock = System.Windows.Forms.DockStyle.Fill;

             
            cboProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            
            lblTitle.Text = "Title:";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;

            
            txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;

           
            lblDescription.Text = "Description:";
            lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;

           
            txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            txtDescription.Multiline = true;
            txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

           
            btnCreateIncident.Text = "Create Incident";
            btnCreateIncident.Width = 140;

           
            btnClear.Text = "Clear";
            btnClear.Width = 80;

             
            lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            
            layout.Controls.Add(lblCustomer, 0, 0);
            layout.Controls.Add(cboCustomer, 1, 0);

            layout.Controls.Add(lblProduct, 0, 1);
            layout.Controls.Add(cboProduct, 1, 1);

            layout.Controls.Add(lblTitle, 0, 2);
            layout.Controls.Add(txtTitle, 1, 2);

            layout.Controls.Add(lblDescription, 0, 3);
            layout.Controls.Add(txtDescription, 1, 3);

           
            var buttonPanel = new System.Windows.Forms.FlowLayoutPanel();
            buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPanel.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            buttonPanel.WrapContents = false;

            buttonPanel.Controls.Add(btnCreateIncident);
            buttonPanel.Controls.Add(btnClear);

            layout.Controls.Add(new System.Windows.Forms.Label() { Text = "", Dock = System.Windows.Forms.DockStyle.Fill }, 0, 4);
            layout.Controls.Add(buttonPanel, 1, 4);

            layout.Controls.Add(new System.Windows.Forms.Label() { Text = "", Dock = System.Windows.Forms.DockStyle.Fill }, 0, 5);
            layout.Controls.Add(lblMessage, 1, 5);
 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(layout);
            Name = "AddIncidentControl";
            Size = new System.Drawing.Size(900, 550);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}