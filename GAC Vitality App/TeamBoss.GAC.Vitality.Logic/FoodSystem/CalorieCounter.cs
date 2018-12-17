using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALFactory;
using TeamBoss.GAC.Vitality.DALInterfaces;

using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class CalorieCounter : ICalorieCounterLogic
    {
        /*private List<MiniRecipe> miniRecipeList { get; set; }
        private List<Recipe> recipeList { get; set; }
        private int calorieAmount { get; set; }
        private int calorieCount { get; set; }

        private IMiniRecipeDAL iMiniRecipeDAL = MiniRecipeDALFactory.CreateMiniRecipeDALInterface();

        public void AddRecipe(Recipe recipe)
        {

        }

        public void AddMiniRecipe(MiniRecipe miniRecipe)
        {

        }

        public void DeleteRecipe(Recipe recipe)
        {

        }

        public void DeleteMiniRecipe(MiniRecipe miniRecipe)
        {

        }

        public void SetCalorieGoal(int calorieGoal)
        {

        }

        public void ResetCalorieAmount()
        {

        }

        public List<MiniRecipe> GetAllMiniRecipes(int userID, bool useTestDatabase)
        {
            List<MiniRecipeStruct> miniRecipeStructs = iMiniRecipeDAL.GetAllMiniRecipesByUserID(userID, useTestDatabase);
            List<MiniRecipe> returnMiniRecipes = new List<MiniRecipe>(miniRecipeStructs.Count);
            // TODO: Load properties of mini recipe from miniRecipeStructs
            miniRecipeStructs.ForEach(miniRecipeStruct => returnMiniRecipes.Add(new MiniRecipe()));

            return returnMiniRecipes;
        }*/

        public List<IMiniRecipeLogic> MiniRecipes { get; set; }
        public List<IRecipeLogic> Recipes { get; set; }
        public int DailyCalorieGoal { get; set; }
        public int TotalCalorieCount { get; set; }

        public bool AddMiniRecipe()
        {
            throw new NotImplementedException();
        }

        public bool AddRecipe()
        {
            throw new NotImplementedException();
        }

        public bool DeleteMiniRecipe()
        {
            throw new NotImplementedException();
        }

        public bool DeleteRecipe()
        {
            throw new NotImplementedException();
        }

        public bool GetAllMiniRecipes()
        {
            throw new NotImplementedException();
        }

        public bool ResetTotalCalorieCount()
        {
            throw new NotImplementedException();
        }

        public bool SetDailyCalorieGoal()
        {
            throw new NotImplementedException();
        }
    }
}
