﻿using System;
using System.Collections.Generic;
using System.Data;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TeamBoss.GAC.Vitality.DAL;

namespace UnitTests
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void OpenCloseConnectionTest()
        {
            Connection testConnection = new Connection();

            testConnection.Open();
            testConnection.Close();
        }

        [TestMethod]
        public void ExecuteQueryTest()
        {
            Connection testConnection = new Connection();
            testConnection.Open();

            DataTable dataTable = testConnection.ExecuteReader("SELECT * FROM [Recipe]");

            testConnection.Close();

            bool actualPizzaName = false;
            foreach(DataRow dataRow in dataTable.Rows)
            {
                if(dataRow["Name"].ToString() == "Pizza")
                {
                    actualPizzaName = true;
                    break;
                }
            }

            Assert.AreEqual(true, actualPizzaName);
        }
    }
}
