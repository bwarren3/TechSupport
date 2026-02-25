namespace TechSupport.View
{
    partial class LoadAllIncidentsControl
    {
        private System.ComponentModel.IContainer components = null;
        internal System.Windows.Forms.DataGridView IncidentDataGridView;

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
            IncidentDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)IncidentDataGridView).BeginInit();
            SuspendLayout();

            IncidentDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            IncidentDataGridView.Name = "IncidentDataGridView";

            Controls.Add(IncidentDataGridView);

            Size = new System.Drawing.Size(900, 550);

            ((System.ComponentModel.ISupportInitialize)IncidentDataGridView).EndInit();
            ResumeLayout(false);
        }
    }
}