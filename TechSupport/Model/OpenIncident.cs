using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents an open incident row to display in the UI.
    /// </summary>
    public class OpenIncident
    {
        /// <summary>
        /// Gets or sets the incident id.
        /// </summary>
        public int IncidentId { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the product name.
        /// </summary>
        public string ProductName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date opened.
        /// </summary>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// Gets or sets the technician name.
        /// </summary>
        public string TechnicianName { get; set; } = string.Empty;
    }
}