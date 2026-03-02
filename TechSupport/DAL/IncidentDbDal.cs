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
        /// <param name="connectionString">The database connection string.</param>
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
                "SELECT i.ProductCode, i.DateOpened ,c.Name AS CustomerName, ISNULL(t.Name, 'Unassigned') AS TechnicianName, " +
                "i.Title " +
                "FROM Incidents i " +
                "JOIN Customers c ON i.CustomerID = c.CustomerID " +
                " LEFT JOIN Technicians t ON i.TechID = t.TechID " +
                "WHERE i.DateClosed IS NULL " +
                "ORDER BY i.DateOpened DESC;";

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                OpenIncident item = new()
                {
                    ProductCode = reader["ProductCode"].ToString() ?? "",
                    DateOpened = (DateTime)reader["DateOpened"],
                    CustomerName = reader["CustomerName"].ToString() ?? "",
                    TechnicianName = reader["TechnicianName"].ToString() ?? "",
                    Title = reader["Title"].ToString() ?? ""
                };

                results.Add(item);
            }

            return results;
        }

        /// <summary>
        /// Adds an incident to the database.
        /// </summary>
        /// <returns> Returns 1 if added</returns>
        public int AddIncident(int customerId, string productCode, string title, string description)
        {
            const string sql = @"
        INSERT INTO Incidents (CustomerID, ProductCode, TechID, DateOpened, DateClosed, Title, Description)
        VALUES (@CustomerID, @ProductCode, NULL, @DateOpened, NULL, @Title, @Description);";

            using SqlConnection conn = new(connectionString);
            using SqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            cmd.Parameters.AddWithValue("@ProductCode", productCode);
            cmd.Parameters.AddWithValue("@DateOpened", DateTime.Now);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Description", description);

            conn.Open();
            return cmd.ExecuteNonQuery(); 
        }
    }
}