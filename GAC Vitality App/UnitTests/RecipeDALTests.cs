﻿using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TeamBoss.GAC.Vitality.DAL;

namespace UnitTests
{
    [TestClass]
    public class RecipeDALTests
    {
        [TestMethod]
        public void GetRecipeByUserIDTest()
        {
            RecipeDAL recipeDAL = new RecipeDAL();
            recipeDAL.GetRecipeListByUserID(1);
        }
    }
}
