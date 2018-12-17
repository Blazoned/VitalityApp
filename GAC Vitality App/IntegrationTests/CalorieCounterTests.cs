using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TeamBoss.GAC.Vitality.Logic;

namespace IntegrationTests
{
    [TestClass]
    public class CalorieCounterTests
    {
        [TestMethod]
        public void GetAllMiniRecipesTest()
        {
            CalorieCounter calorieCounter = new CalorieCounter();

            List<MiniRecipe> miniRecipes = calorieCounter.GetAllMiniRecipes(1);

            Assert.AreEqual(3, miniRecipes.Count);
        }
    }
}
