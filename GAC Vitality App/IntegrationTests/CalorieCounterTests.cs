using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TeamBoss.GAC.Vitality.Logic.FoodSystem;

namespace IntegrationTests
{
    [TestClass]
    public class CalorieCounterTests
    {
        [TestMethod]
        public void GetAllMiniRecipes()
        {
            CalorieCounter calorieCounter = new CalorieCounter();

            List<MiniRecipe> miniRecipes = calorieCounter.GetAllMiniRecipes(1, true);

            Assert.AreEqual(3, miniRecipes.Count);
        }
    }
}
