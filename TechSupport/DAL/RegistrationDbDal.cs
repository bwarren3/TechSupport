using Microsoft.Data.SqlClient;

namespace TechSupport.DAL
{
    /// <summary>
    /// Provides database access for registrations.
    /// </summary>
    public class RegistrationDbDal
    {
        private readonly string connectionString;

        public RegistrationDbDal()
        {
            DbConfig config = new DbConfig();
            connectionString = config.ConnectionString;
        }

        public bool RegistrationExists(int customerId, string productCode)
        {
            const string sql = @"
                SELECT COUNT(*)
                FROM Registrations
                WHERE CustomerID = @CustomerID AND ProductCode = @ProductCode;";

            using SqlConnection conn = new(connectionString);
            using SqlCommand cmd = new(sql, conn);

            cmd.Parameters.AddWithValue("@CustomerID", customerId);
            cmd.Parameters.AddWithValue("@ProductCode", productCode);

            conn.Open();
            int count = (int)cmd.ExecuteScalar()!;
            return count > 0;
        }
    }
}