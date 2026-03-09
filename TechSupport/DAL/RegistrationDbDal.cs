using Microsoft.Data.SqlClient;
using System.Data;

namespace TechSupport.DAL
{
    /// <summary>
    /// Provides database access for registrations.
    /// </summary>
    public class RegistrationDbDal
    {
        private readonly string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationDbDal"/> class.
        /// </summary>
        public RegistrationDbDal()
        {
            DbConfig config = new DbConfig();
            connectionString = config.ConnectionString;
        }

        /// <summary>
        /// Determines whether a registration exists for the specified customer and product.
        /// </summary>
        /// <param name="customerId">The customer identifier.</param>
        /// <param name="productCode">The product code.</param>
        /// <returns>True if a matching registration exists; otherwise false.</returns>
        public bool RegistrationExists(int customerId, string productCode)
        {
            const string sql = @"
                SELECT COUNT(*)
                FROM Registrations
                WHERE CustomerID = @CustomerID AND ProductCode = @ProductCode;";

            using SqlConnection conn = new(connectionString);
            using SqlCommand cmd = new(sql, conn);

            cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerId;
            cmd.Parameters.Add("@ProductCode", SqlDbType.VarChar, 10).Value = productCode;

            conn.Open();
            int count = (int)cmd.ExecuteScalar()!;
            return count > 0;
        }
    }
}