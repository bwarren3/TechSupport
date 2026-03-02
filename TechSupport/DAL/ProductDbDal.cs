using Microsoft.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Provides database access for products.
    /// </summary>
    public class ProductDbDal
    {
        private readonly string connectionString;

        public ProductDbDal()
        {
            DbConfig config = new DbConfig();
            connectionString = config.ConnectionString;
        }

        public List<Product> GetProducts()
        {
            List<Product> products = new();

            const string sql = @"
                SELECT ProductCode, Name
                FROM Products
                ORDER BY Name;";

            using SqlConnection conn = new(connectionString);
            using SqlCommand cmd = new(sql, conn);

            conn.Open();
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                products.Add(new Product
                {
                    ProductCode = reader["ProductCode"].ToString() ?? "",
                    Name = reader["Name"].ToString() ?? ""
                });
            }

            return products;
        }
    }
}