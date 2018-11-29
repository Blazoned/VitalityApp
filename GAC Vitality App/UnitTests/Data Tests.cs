using System;
using System.Collections.Generic;
using System.Data;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TeamBoss.GAC.Vitality.Data;

namespace UnitTests
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void OpenCloseConnectionTest()
        {
            Connection testConnection = new Connection("den1.mssql7.gear.host", "1433", "vitalitydatabase", "Eu4q81-5fkU!");

            testConnection.Open();
            testConnection.Close();
        }

        [TestMethod]
        public void ExecuteQueryTest()
        {
            Connection testConnection = new Connection("den1.mssql7.gear.host", "1433", "vitalitydatabase", "Eu4q81-5fkU!");
            testConnection.Open();

            DataTable dataTable = testConnection.ExecuteReader("SELECT * FROM [Recipe]");

            testConnection.Close();

            bool actualPizzaName = ((string)dataTable.Rows[0]["Name"] == "Pizza");
            bool actualSaladeName = ((string)dataTable.Rows[1]["Name"] == "Fruitsalade");

            Assert.AreEqual(true, actualPizzaName && actualSaladeName);
        }
    }
}
