using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.LogicInterfaces
{
    public interface ICalorieCounterLogic
    {
        List<IMiniRecipeLogic> MiniRecipes { get; set; }
        List<IRecipeLogic> Recipes { get; set; }
        int DailyCalorieGoal { get; set; }
        int TotalCalorieCount { get; set; }

        bool AddRecipe();
        bool AddMiniRecipe();
        bool DeleteRecipe();
        bool DeleteMiniRecipe();
        bool SetDailyCalorieGoal();
        bool ResetTotalCalorieCount();
        bool GetAllMiniRecipes();
    }
}
