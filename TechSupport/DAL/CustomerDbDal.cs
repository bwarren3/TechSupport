using Microsoft.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Provides database access for customers.
    /// </summary>
    public class CustomerDbDal
    {
        private readonly string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDbDal"/> class.
        /// </summary>
        public CustomerDbDal()
        {
            DbConfig config = new DbConfig();
            connectionString = config.ConnectionString;
        }

        /// <summary>
        /// Gets all customers from the database.
        /// </summary>
        /// <returns>A list of customers ordered by name.</returns>
        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new();

            const string sql = @"
                SELECT CustomerID, Name
                FROM Customers
                ORDER BY Name;";

            using SqlConnection conn = new(connectionString);
            using SqlCommand cmd = new(sql, conn);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    CustomerID = (int)reader["CustomerID"],
                    Name = reader["Name"].ToString() ?? string.Empty
                });
            }

            return customers;
        }
    }
}