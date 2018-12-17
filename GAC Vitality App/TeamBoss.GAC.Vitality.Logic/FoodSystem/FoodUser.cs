using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALFactory;
using TeamBoss.GAC.Vitality.DALInterfaces;

using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace TeamBoss.GAC.Vitality.Logic.FoodSystem
{
    public class FoodUser : User, IFoodUser
    {
        private List<Recipe> myRecipeList { get; set; }
        private List<Recipe> favoriteRecipeList { get; set; }
        private CalorieCounter calorieCounter { get; set; }

        private IRecipeDAL iRecipeDAL = RecipeFactory.CreateRecipeInterface();

        public FoodUser()
        {
            myRecipeList = GetMyRecipes();
        }

        public List<Recipe> GetMyRecipes()
        {
            List<RecipeStruct> recipeStructs = iRecipeDAL.GetRecipeListByUserID(Id);
            List<Recipe> recipes = new List<Recipe>();
            recipeStructs.ForEach(recipeStruct => recipes.Add(new Recipe(recipeStruct)));

            return recipes; 
        }

        public void AddRecipe(string username, string name, string description, List<Allergenes> allergeneList, List<string> ingredients, int preperationTime, int totalCalories, List<string> imageList, int personAmount)
        {

        }

        public void DeleteRecipe(Recipe recipe)
        {

        }

        public void FavoriteRecipe(Recipe recipe)
        {

        }

        public void UnfavoriteRecipe(Recipe recipe)
        {

        }

    }
}
