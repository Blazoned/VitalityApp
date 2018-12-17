using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TeamBoss.GAC.Vitality.Logic;
using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace IntegrationTests
{
    [TestClass]
    public class FoodUserTests
    {
        [TestMethod]

        public void GetMyRecipesTest()
        {
            //arrange
            FoodUser user = new FoodUser();
            user.SetProperties(); // Set Here

            //act
            user.GetMyRecipes();
            int actual = user.MyRecipes.Count;
            int expected = 2;

            //assert
            Assert.AreEqual(expected, actual); 

        }
    }
}
