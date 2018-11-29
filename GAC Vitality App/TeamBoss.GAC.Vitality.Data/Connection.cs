using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TeamBoss.GAC.Vitality.Data
{
    public class Connection
    {
        SqlConnection c = new SqlConnection();
        SqlConnectionStringBuilder b = new SqlConnectionStringBuilder();

        public Connection()
        {
            b.UserID = "vitalitydatabase";
            b.Password = "Eu4q81-5fkU!";
            b.InitialCatalog = "vitalitydatabase";
            b.DataSource = "den1.mssql7.gear.host";
            b.PersistSecurityInfo = true;
            c.ConnectionString = b.ConnectionString;
        }

        public string GetConnectionString()
        {
            string result = b.ConnectionString;
            return result;
        }
    }
}
