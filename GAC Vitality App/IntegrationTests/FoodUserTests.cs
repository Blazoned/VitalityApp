using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using TeamBoss.GAC.Vitality.Logic;

namespace IntegrationTests
{
    [TestClass]
    public class FoodUserTests
    {
        [TestMethod]

        public void GetMyRecipesTest()
        {
            //arrange
            FoodUser user = new FoodUser(1);

            //act
            int actual = user.GetMyRecipes().Count;
            int expected = 2;

            //assert
            Assert.AreEqual(expected, actual); 

        }
    }
}
