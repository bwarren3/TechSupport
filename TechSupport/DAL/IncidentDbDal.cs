using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
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
        public IncidentDbDal(string connectionString)
        {
            this.connectionString = connectionString;
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
                "SELECT i.IncidentID, c.Name AS CustomerName, p.Name AS ProductName, i.DateOpened, " +
                "t.Name AS TechnicianName " +
                "FROM Incidents i " +
                "JOIN Customers c ON i.CustomerID = c.CustomerID " +
                "JOIN Products p ON i.ProductCode = p.ProductCode " +
                "JOIN Technicians t ON i.TechID = t.TechID " +
                "WHERE i.DateClosed IS NULL " +
                "ORDER BY i.DateOpened DESC, i.IncidentID DESC;";

            connection.Open();

            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                OpenIncident item = new()
                {
                    IncidentId = reader.GetInt32(reader.GetOrdinal("IncidentID")),
                    CustomerName = reader.GetString(reader.GetOrdinal("CustomerName")),
                    ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                    DateOpened = reader.GetDateTime(reader.GetOrdinal("DateOpened")),
                    TechnicianName = reader.GetString(reader.GetOrdinal("TechnicianName"))
                };

                results.Add(item);
            }

            return results;
        }
    }
}