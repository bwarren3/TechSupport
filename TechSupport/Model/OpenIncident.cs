using System;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents a row used to display open incidents.
    /// </summary>
    public class OpenIncident
    {
        /// <summary>
        /// Gets or sets the product code.
        /// </summary>
        public string ProductCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date opened.
        /// </summary>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the technician name.
        /// </summary>
        public string TechnicianName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the incident title.
        /// </summary>
        public string Title { get; set; } = string.Empty;
    }
}