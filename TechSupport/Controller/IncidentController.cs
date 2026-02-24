using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Handles business logic related to incidents.
    /// </summary>
    public class IncidentController
    {
        /// <summary>
        /// Gets all incidents.
        /// </summary>
        /// <returns>A list of all incidents.</returns>
        public List<Incident> GetAllIncidents()
        {
            return IncidentRepository.GetAll();
        }

        /// <summary>
        /// Adds a new incident.
        /// </summary>
        /// <param name="incident">The incident to add.</param>
        public void AddIncident(Incident incident)
        {
            IncidentRepository.Add(incident);
        }

        /// <summary>
        /// Searches incidents by customer ID.
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <returns>A list of matching incidents.</returns>
        public List<Incident> SearchIncidentsByCustomerId(int customerId)
        {
            return IncidentRepository.GetByCustomerId(customerId);
        }
    }
}
