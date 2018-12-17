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
    public class FoodUser : User, IFoodUserLogic
    {
        private List<Recipe> MyRecipeList { get; set; }
        private List<Recipe> FavoriteRecipeList { get; set; }
        private CalorieCounter CalorieCounter { get; set; }

        private IRecipeDAL iRecipeDAL = RecipeDALFactory.CreateRecipeDALInterface();

        public FoodUser(int id) : base(id)
        {
            MyRecipeList = GetMyRecipes();
        }

        public List<Recipe> GetMyRecipes()
        {
            List<RecipeStruct> recipeStructs = iRecipeDAL.GetRecipeListByUserID(Id);
            List<Recipe> recipes = new List<Recipe>();
            recipeStructs.ForEach(recipeStruct => recipes.Add(new Recipe(recipeStruct)));

            return recipes; 
        }

        public bool AddRecipe(string username, string name, string description, List<Allergene> allergeneList, List<string> ingredients, int preperationTime, int totalCalories, List<string> imageList, int personAmount)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public bool FavoriteRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public bool UnfavoriteRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

    }
}
