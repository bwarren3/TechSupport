using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Coordinates incident operations between the UI and data layers.
    /// </summary>
    public class IncidentController
    {
        private const string DefaultConnectionString =
            "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=TechSupport;Integrated Security=True;";

        private readonly IncidentRepository inMemoryRepository;
        private readonly IncidentDbDal incidentDbDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentController"/> class using the default connection string.
        /// </summary>
        public IncidentController() : this(DefaultConnectionString)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentController"/> class using a provided connection string.
        /// </summary>
        /// <param name="connectionString">The database connection string.</param>
        public IncidentController(string connectionString)
        {
            inMemoryRepository = new IncidentRepository();
            incidentDbDal = new IncidentDbDal(connectionString);
        }

        /// <summary>
        /// Gets all incidents from the in-memory list.
        /// </summary>
        /// <returns>A list of incidents.</returns>
        public List<Incident> GetAllIncidents()
        {
            return inMemoryRepository.GetAll();
        }

        /// <summary>
        /// Adds an incident to the in-memory list.
        /// </summary>
        /// <param name="incident">The incident to add.</param>
        public void AddIncident(Incident incident)
        {
            inMemoryRepository.Add(incident);
        }

        /// <summary>
        /// Searches incidents in the in-memory list by customer id.
        /// </summary>
        /// <param name="customerId">Customer id to search.</param>
        /// <returns>A list of matching incidents.</returns>
        public List<Incident> SearchIncidentsByCustomerId(int customerId)
        {
            return inMemoryRepository.GetByCustomerId(customerId);
        }

        /// <summary>
        /// Gets open incidents from the database.
        /// </summary>
        /// <returns>A list of open incidents.</returns>
        public List<OpenIncident> GetOpenIncidents()
        {
            return incidentDbDal.GetOpenIncidents();
        }
    }
}