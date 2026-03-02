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

        public CustomerDbDal()
        {
            DbConfig config = new DbConfig();
            connectionString = config.ConnectionString;
        }

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
                    Name = reader["Name"].ToString() ?? ""
                });
            }

            return customers;
        }
    }
}
