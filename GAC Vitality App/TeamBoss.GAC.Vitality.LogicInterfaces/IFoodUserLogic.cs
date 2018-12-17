using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALInterfaces;

namespace TeamBoss.GAC.Vitality.LogicInterfaces
{
    public interface IFoodUserLogic
    {
        List<IRecipeLogic> MyRecipes { get; set; }
        List<IRecipeLogic> FavouriteRecipes { get; set; }
        ICalorieCounterLogic iCalorieCounter { get; set; }
        IRecipeDAL iRecipeDAL { get; set; }

        bool AddRecipe();
        bool DeleteRecipe();
        bool FavouriteRecipe();
        bool GetMyRecipes();
        bool UnFavouriteRecipe();
        void SetProperties();
    }
}
