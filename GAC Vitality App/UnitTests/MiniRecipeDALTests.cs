using System;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using TeamBoss.GAC.Vitality.DAL;
using TeamBoss.GAC.Vitality.DALInterfaces;

namespace UnitTests
{
    [TestClass]
    public class MiniRecipeDALTests
    {
        [TestMethod]
        public void GetAllMiniRecipesByUserIDCorrectCountTest()
        {
            IMiniRecipeDAL iMiniRecipeDAL = new MiniRecipeDAL();
            List<MiniRecipeStruct> miniRecipeList = iMiniRecipeDAL.GetAllMiniRecipesByUserID(1, true);

            Assert.AreEqual(3, miniRecipeList.Count);
        }

        [TestMethod]
        public void GetAllMiniRecipesByUserIDWrongCountTest()
        {
            IMiniRecipeDAL iMiniRecipeDAL = new MiniRecipeDAL();
            List<MiniRecipeStruct> miniRecipeList = iMiniRecipeDAL.GetAllMiniRecipesByUserID(1, true);

            Assert.AreNotEqual(4, miniRecipeList.Count);
        }
    }
}
