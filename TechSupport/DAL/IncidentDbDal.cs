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

        /// <summary>
        /// Gets one incident by its ID.
        /// </summary>
        /// <param name="incidentId">The incident ID.</param>
        /// <returns>The incident if found; otherwise null.</returns>
        public IncidentDetail? GetIncidentById(int incidentId)
        {
            const string sql = @"
                SELECT i.IncidentID,
                       i.CustomerID,
                       c.Name AS CustomerName,
                       i.ProductCode,
                       i.TechID,
                       ISNULL(t.Name, 'Unassigned') AS TechnicianName,
                       i.Title,
                       i.DateOpened,
                       i.DateClosed,
                       i.Description
                FROM Incidents i
                JOIN Customers c ON i.CustomerID = c.CustomerID
                LEFT JOIN Technicians t ON i.TechID = t.TechID
                WHERE i.IncidentID = @IncidentID;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(sql, connection);

            command.Parameters.Add("@IncidentID", SqlDbType.Int).Value = incidentId;

            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            return new IncidentDetail
            {
                IncidentID = (int)reader["IncidentID"],
                CustomerID = (int)reader["CustomerID"],
                CustomerName = reader["CustomerName"].ToString() ?? string.Empty,
                ProductCode = reader["ProductCode"].ToString() ?? string.Empty,
                TechID = reader["TechID"] == DBNull.Value ? null : (int)reader["TechID"],
                TechnicianName = reader["TechnicianName"].ToString() ?? string.Empty,
                Title = reader["Title"].ToString() ?? string.Empty,
                DateOpened = (DateTime)reader["DateOpened"],
                DateClosed = reader["DateClosed"] == DBNull.Value ? null : (DateTime)reader["DateClosed"],
                Description = reader["Description"].ToString() ?? string.Empty
            };
        }

        /// <summary>
        /// Updates an incident's technician and description.
        /// </summary>
        /// <param name="incidentId">The incident ID.</param>
        /// <param name="techId">The technician ID, or null for unassigned.</param>
        /// <param name="description">The full updated description.</param>
        /// <returns>The number of rows affected.</returns>
        public int UpdateIncident(int incidentId, int? techId, string description)
        {
            const string sql = @"
                UPDATE Incidents
                SET TechID = @TechID,
                    Description = @Description
                WHERE IncidentID = @IncidentID;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(sql, connection);

            command.Parameters.Add("@IncidentID", SqlDbType.Int).Value = incidentId;

            SqlParameter techParam = command.Parameters.Add("@TechID", SqlDbType.Int);
            if (techId.HasValue)
            {
                techParam.Value = techId.Value;
            }
            else
            {
                techParam.Value = DBNull.Value;
            }

            command.Parameters.Add("@Description", SqlDbType.VarChar, 200).Value = description;

            connection.Open();
            return command.ExecuteNonQuery();
        }

        /// <summary>
        /// Updates an incident and closes it by setting DateClosed to the current date/time.
        /// </summary>
        /// <param name="incidentId">The incident ID.</param>
        /// <param name="techId">The technician ID.</param>
        /// <param name="description">The full updated description.</param>
        /// <returns>The number of rows affected.</returns>
        public int CloseIncident(int incidentId, int techId, string description)
        {
            const string sql = @"
                UPDATE Incidents
                SET TechID = @TechID,
                    Description = @Description,
                    DateClosed = @DateClosed
                WHERE IncidentID = @IncidentID;";

            using SqlConnection connection = new(connectionString);
            using SqlCommand command = new(sql, connection);

            command.Parameters.Add("@IncidentID", SqlDbType.Int).Value = incidentId;
            command.Parameters.Add("@TechID", SqlDbType.Int).Value = techId;
            command.Parameters.Add("@Description", SqlDbType.VarChar, 200).Value = description;
            command.Parameters.Add("@DateClosed", SqlDbType.DateTime).Value = DateTime.Now;

            connection.Open();
            return command.ExecuteNonQuery();
        }
    }
}