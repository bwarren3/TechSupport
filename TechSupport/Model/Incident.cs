using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
    /// <summary>
    /// Represents a tech support incident.
    /// </summary>
    public class Incident
    {
        /// <summary>
        /// Gets or sets the incident ID.
        /// </summary>
        public int IncidentId { get; set; }

        /// <summary>
        /// Gets or sets the incident title.
        /// </summary>
        public string Title { get; set; } = "";

        /// <summary>
        /// Gets or sets the incident description.
        /// </summary>
        public string Description { get; set; } = "";

        /// <summary>
        /// Gets or sets the customer ID for this incident.
        /// </summary>
        public int CustomerId { get; set; }
    }
}

