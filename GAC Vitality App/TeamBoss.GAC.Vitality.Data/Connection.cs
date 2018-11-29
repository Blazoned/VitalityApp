using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Data
{
    public class Connection
    {
        /// <summary>
        /// The connection object.
        /// </summary>
        private SqlConnection connection;

        /// <summary>
        /// Creates a new connection object with the given parameters as its connection string.
        /// </summary>
        /// <param name="databaseAddress">The address of the database server.</param>
        /// <param name="databasePort">The port to connect through.</param>
        /// <param name="userID">The user ID to connect with.</param>
        /// <param name="password">The password to connect with.</param>
        public Connection(string databaseAddress, string databasePort, string userID, string password)
        {
            string connectionString = "server=" + databaseAddress + "," + databasePort + ";uid=" + userID + ";password=" + password;
            connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Executes the given query on the database and returns the results in a DataTable.
        /// </summary>
        /// <param name="query">The SQL query to execute.</param>
        /// <returns>A DataTable containing the results of the query.</returns>
        public DataTable ExecuteReader(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable returnTable = new DataTable();
            returnTable.Load(reader);

            reader.Close();

            return returnTable;
        }

        /// <summary>
        /// Executes the given query on the database and returns the number of rows affected by it.
        /// </summary>
        /// <param name="query">The SQL query to execute on the database.</param>
        /// <returns>The number of rows affected by the query.</returns>
        public int ExecuteWriter(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);
            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Closes the connection.
        /// </summary>
        public void Close()
        {
            connection.Close();
        }

        /// <summary>
        /// Opens the connection for use.
        /// </summary>
        public void Open()
        {
            connection.Open();
        }
    }
}
