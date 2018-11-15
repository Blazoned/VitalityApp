using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic.FoodSystem
{
    public class FoodUser : User
    {
        private List<Recipe> myRecipeList { get; set; }
        private List<Recipe> favoriteRecipeList { get; set; }
        private CalorieCounter calorieCounter { get; set; }

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
