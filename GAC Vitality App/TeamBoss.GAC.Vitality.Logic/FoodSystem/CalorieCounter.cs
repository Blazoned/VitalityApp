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
    public class CalorieCounter 
    {
        public List<MiniRecipe> MiniRecipes { get; set; }
        public List<Recipe> Recipes { get; set; }
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
