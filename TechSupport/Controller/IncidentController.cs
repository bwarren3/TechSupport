using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    /// <summary>
    /// Coordinates incident operations between the UI and data layers.
    /// </summary>
    public class IncidentController
    {
        
        private readonly IncidentRepository inMemoryRepository;

       
        private readonly IncidentDbDal incidentDbDal;
        private readonly CustomerDbDal customerDbDal;
        private readonly ProductDbDal productDbDal;
        private readonly RegistrationDbDal registrationDbDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentController"/> class.
        /// </summary>
        public IncidentController()
        {
            
            inMemoryRepository = new IncidentRepository();

            incidentDbDal = new IncidentDbDal();
            customerDbDal = new CustomerDbDal();
            productDbDal = new ProductDbDal();
            registrationDbDal = new RegistrationDbDal();
        }

        /// <summary>
        /// Gets all incidents from the in-memory list.
        /// </summary>
        public List<Incident> GetAllIncidents()
        {
            return inMemoryRepository.GetAll();
        }

        /// <summary>
        /// Adds an incident to the in-memory list.
        /// </summary>
        public void AddIncident(Incident incident)
        {
            inMemoryRepository.Add(incident);
        }

        /// <summary>
        /// Searches incidents in the in-memory list by customer id.
        /// </summary>
        public List<Incident> SearchIncidentsByCustomerId(int customerId)
        {
            return inMemoryRepository.GetByCustomerId(customerId);
        }

        /// <summary>
        /// Gets open incidents from the database.
        /// </summary>
        public List<OpenIncident> GetOpenIncidents()
        {
            return incidentDbDal.GetOpenIncidents();
        }

        /// <summary>
        /// Gets all customers for the Add Incident dropdown.
        /// </summary>
        public List<Customer> GetCustomers()
        {
            return customerDbDal.GetCustomers();
        }

        /// <summary>
        /// Gets all products for the Add Incident dropdown.
        /// </summary>
        public List<Product> GetProducts()
        {
            return productDbDal.GetProducts();
        }

        /// <summary>
        /// Checks whether the selected customer has a registration for the selected product.
        /// </summary>
        public bool RegistrationExists(int customerId, string productCode)
        {
            return registrationDbDal.RegistrationExists(customerId, productCode);
        }

        /// <summary>
        /// Creates a new incident in the database (after validation is done in the UI/controller).
        /// </summary>
        /// <returns>true if inserted; false otherwise.</returns>
        public bool CreateIncident(int customerId, string productCode, string title, string description)
        {
            int rowsAffected = incidentDbDal.AddIncident(customerId, productCode, title, description);
            return rowsAffected == 1;
        }
    }
}