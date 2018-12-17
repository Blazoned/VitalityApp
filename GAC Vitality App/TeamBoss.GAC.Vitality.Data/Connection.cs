using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.DAL
{
    public class Connection
    {
        /// <summary>
        /// The connection object.
        /// </summary>
        private SqlConnection connection = new SqlConnection();
        private string normalConnectionString = "Data Source = den1.mssql7.gear.host; Initial Catalog = vitalitydatabase; User Id = vitalitydatabase; Password = Eu4q81-5fkU!;";
        private string testConnectionString = "Data Source = den1.mssql8.gear.host; Initial Catalog = vitalitytestdb2; User Id = vitalitytestdb2; Password = Kh3Tq14~D5?5;";

        public Connection(bool useTestDatabase = false)
        {
            if(useTestDatabase)
            {
                connection.ConnectionString = testConnectionString;
            }
            else
            {
                connection.ConnectionString = normalConnectionString;
            }
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
