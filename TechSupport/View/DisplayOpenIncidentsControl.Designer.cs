namespace TechSupport.View
{
    partial class DisplayOpenIncidentsControl
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.ListView OpenIncidentsListView;
        private System.Windows.Forms.ColumnHeader IncidentIdColumn;
        private System.Windows.Forms.ColumnHeader CustomerColumn;
        private System.Windows.Forms.ColumnHeader ProductColumn;
        private System.Windows.Forms.ColumnHeader DateOpenedColumn;
        private System.Windows.Forms.ColumnHeader TechnicianColumn;

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
            OpenIncidentsListView = new System.Windows.Forms.ListView();
            IncidentIdColumn = new System.Windows.Forms.ColumnHeader();
            CustomerColumn = new System.Windows.Forms.ColumnHeader();
            ProductColumn = new System.Windows.Forms.ColumnHeader();
            DateOpenedColumn = new System.Windows.Forms.ColumnHeader();
            TechnicianColumn = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();

            OpenIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                IncidentIdColumn,
                CustomerColumn,
                ProductColumn,
                DateOpenedColumn,
                TechnicianColumn
            });

            OpenIncidentsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            OpenIncidentsListView.Name = "OpenIncidentsListView";
            OpenIncidentsListView.TabIndex = 0;
            OpenIncidentsListView.UseCompatibleStateImageBehavior = false;

            IncidentIdColumn.Text = "Incident ID";
            IncidentIdColumn.Width = 90;

            CustomerColumn.Text = "Customer";
            CustomerColumn.Width = 220;

            ProductColumn.Text = "Product";
            ProductColumn.Width = 220;

            DateOpenedColumn.Text = "Date Opened";
            DateOpenedColumn.Width = 120;

            TechnicianColumn.Text = "Technician";
            TechnicianColumn.Width = 200;

            Controls.Add(OpenIncidentsListView);

            Name = "DisplayOpenIncidentsControl";
            Size = new System.Drawing.Size(900, 550);

            ResumeLayout(false);
        }
    }
}