using Microsoft.Data.SqlClient;
using System.Data;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Provides database access for incidents.
    /// </summary>
    public class IncidentDbDal
    {
        private readonly string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentDbDal"/> class.
        /// </summary>
        public IncidentDbDal()
        {
            DbConfig config = new DbConfig();
            connectionString = config.ConnectionString;
        }

        /// <summary>
        /// Gets all open incidents from the database.
        /// </summary>
        /// <returns>A list of open incidents.</returns>
        public List<OpenIncident> GetOpenIncidents()
        {
            List<OpenIncident> results = new();

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText =
                "SELECT i.ProductCode, i.DateOpened, c.Name AS CustomerName, ISNULL(t.Name, 'Unassigned') AS TechnicianName, " +
                "i.Title " +
                "FROM Incidents i " +
                "JOIN Customers c ON i.CustomerID = c.CustomerID " +
                "LEFT JOIN Technicians t ON i.TechID = t.TechID " +
                "WHERE i.DateClosed IS NULL " +
                "ORDER BY i.DateOpened DESC;";

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                OpenIncident item = new()
                {
                    ProductCode = reader["ProductCode"].ToString() ?? string.Empty,
                    DateOpened = (DateTime)reader["DateOpened"],
                    CustomerName = reader["CustomerName"].ToString() ?? string.Empty,
                    TechnicianName = reader["TechnicianName"].ToString() ?? string.Empty,
                    Title = reader["Title"].ToString() ?? string.Empty
                };

                results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Adds a new incident to the database.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="productCode">The product code.</param>
        /// <param name="title">The incident title.</param>
        /// <param name="description">The incident description.</param>
        /// <returns>The number of rows affected.</returns>
        public int AddIncident(int customerId, string productCode, string title, string description)
        {
            const string sql = @"
                INSERT INTO Incidents (CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description)
                VALUES (@CustomerID, @ProductCode, NULL, @DateOpened, NULL, @Title, @Description);";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(sql, connection);

            command.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerId;
            command.Parameters.Add("@ProductCode", SqlDbType.VarChar, 10).Value = productCode;
            command.Parameters.Add("@DateOpened", SqlDbType.DateTime).Value = DateTime.Now;
            command.Parameters.Add("@Title", SqlDbType.VarChar, 50).Value = title;
            command.Parameters.Add("@Description", SqlDbType.VarChar).Value = description;

            connection.Open();
            return command.ExecuteNonQuery();
        }
    }
}