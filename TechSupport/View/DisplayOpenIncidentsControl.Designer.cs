namespace TechSupport.View
{
    partial class DisplayOpenIncidentsControl
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.ListView OpenIncidentsListView;
        private System.Windows.Forms.ColumnHeader ProductCodeColumn;
        private System.Windows.Forms.ColumnHeader CustomerColumn;
        private System.Windows.Forms.ColumnHeader TitleColumn;
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
            this.OpenIncidentsListView = new System.Windows.Forms.ListView();
            this.ProductCodeColumn = new System.Windows.Forms.ColumnHeader();
            this.DateOpenedColumn = new System.Windows.Forms.ColumnHeader();
            this.CustomerColumn = new System.Windows.Forms.ColumnHeader();
            this.TechnicianColumn = new System.Windows.Forms.ColumnHeader();
            this.TitleColumn = new System.Windows.Forms.ColumnHeader();
            SuspendLayout();

            this.OpenIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductCodeColumn,
            this.DateOpenedColumn,
            this.CustomerColumn,
            this.TechnicianColumn,
            this.TitleColumn
        });

            OpenIncidentsListView.Dock = DockStyle.Fill;
            OpenIncidentsListView.Name = "OpenIncidentsListView";
            OpenIncidentsListView.TabIndex = 0;
            OpenIncidentsListView.UseCompatibleStateImageBehavior = false;

            this.ProductCodeColumn.Text = "Product Code";
            this.ProductCodeColumn.Width = 100;

            this.DateOpenedColumn.Text = "Date Opened";
            this.DateOpenedColumn.Width = 120;

            this.CustomerColumn.Text = "Customer";
            this.CustomerColumn.Width = 180;

            this.TechnicianColumn.Text = "Technician";
            this.TechnicianColumn.Width = 150;

            this.TitleColumn.Text = "Title";
            this.TitleColumn.Width = 250; ;

            Controls.Add(OpenIncidentsListView);

            Name = "DisplayOpenIncidentsControl";
            Size = new System.Drawing.Size(900, 550);

            ResumeLayout(false);
        }
    }
}