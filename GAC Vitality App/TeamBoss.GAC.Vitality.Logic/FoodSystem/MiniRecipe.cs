using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALInterfaces;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class MiniRecipe
    {
        private int totalCalories { get; set; }
        private string username { get; set; }

        public MiniRecipe(MiniRecipeStruct miniRecipeStruct)
        {
            totalCalories = miniRecipeStruct.CalorieAmount;
            username = miniRecipeStruct.Name;
        }
    }
}
