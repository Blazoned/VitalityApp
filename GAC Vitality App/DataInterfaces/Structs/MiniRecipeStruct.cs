using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.DALInterfaces
{
    public struct MiniRecipeStruct
    {
        public int CalorieAmount { get; private set; }
        public string Name { get; private set; }

        public MiniRecipeStruct(int _calorieAmount, string _name)
        {
            CalorieAmount = _calorieAmount;
            Name = _name;
        }
    }
}
