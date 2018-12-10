using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALFactory;
using TeamBoss.GAC.Vitality.DataInterfaces;

namespace TeamBoss.GAC.Vitality.Logic.FoodSystem
{
    public class CalorieCounter
    {
        private List<MiniRecipe> miniRecipeList { get; set; }
        private List<Recipe> recipeList { get; set; }
        private int calorieAmount { get; set; }
        private int calorieCount { get; set; }

        private IMiniRecipeDAL iMiniRecipeDAL = MiniRecipeFactory.CreateMiniRecipeInterface();

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
            miniRecipeStructs.ForEach(miniRecipeStruct => returnMiniRecipes.Add(new MiniRecipe(miniRecipeStruct)));

            return returnMiniRecipes;
        }
    }
}
