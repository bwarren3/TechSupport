using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Simulates persistent data storage for incidents.
    /// </summary>
    public class IncidentRepository
    {
        private readonly List<Incident> incidents = new();
        private int nextId = 1;

        /// <summary>
        /// Gets all incidents.
        /// </summary>
        /// <returns>All incidents.</returns>
        public List<Incident> GetAll()
        {
            return incidents.ToList();
        }

        /// <summary>
        /// Adds an incident to the repository.
        /// </summary>
        /// <param name="incident">The incident to add.</param>
        public void Add(Incident incident)
        {
            incident.IncidentId = nextId++;
            incidents.Add(incident);
        }

        /// <summary>
        /// Gets incidents for a specific customer.
        /// </summary>
        /// <param name="customerId">Customer ID.</param>
        /// <returns>Matching incidents.</returns>
        public List<Incident> GetByCustomerId(int customerId)
        {
            return incidents.Where(i => i.CustomerId == customerId).ToList();
        }
    }
}
