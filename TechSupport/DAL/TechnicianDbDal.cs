using Microsoft.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// Provides database access for technicians.
    /// </summary>
    public class TechnicianDbDal
    {
        private readonly string connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="TechnicianDbDal"/> class.
        /// </summary>
        public TechnicianDbDal()
        {
            DbConfig config = new DbConfig();
            connectionString = config.ConnectionString;
        }

        /// <summary>
        /// Gets all technicians ordered by name.
        /// </summary>
        /// <returns>A list of technicians.</returns>
        public List<Technician> GetTechnicians()
        {
            List<Technician> technicians = new();

            const string sql = @"
                SELECT TechID, Name
                FROM Technicians
                ORDER BY Name;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(sql, connection);

            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                technicians.Add(new Technician
                {
                    TechID = (int)reader["TechID"],
                    Name = reader["Name"].ToString() ?? string.Empty
                });
            }

            return technicians;
        }
    }
}