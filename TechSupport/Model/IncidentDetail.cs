namespace TechSupport.Model
{
    /// <summary>
    /// Represents the full set of details for a single incident.
    /// </summary>
    public class IncidentDetail
    {
        /// <summary>
        /// Gets or sets the incident identifier.
        /// </summary>
        public int IncidentID { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier.
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        public string CustomerName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the product code associated with the incident.
        /// </summary>
        public string ProductCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the technician identifier, if one is assigned.
        /// </summary>
        public int? TechID { get; set; }

        /// <summary>
        /// Gets or sets the technician name.
        /// </summary>
        public string TechnicianName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the incident title.
        /// </summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the date the incident was opened.
        /// </summary>
        public DateTime DateOpened { get; set; }

        /// <summary>
        /// Gets or sets the date the incident was closed, if it has been closed.
        /// </summary>
        public DateTime? DateClosed { get; set; }

        /// <summary>
        /// Gets or sets the incident description.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Gets a value indicating whether the incident is closed.
        /// </summary>
        public bool IsClosed => DateClosed.HasValue;
    }
}