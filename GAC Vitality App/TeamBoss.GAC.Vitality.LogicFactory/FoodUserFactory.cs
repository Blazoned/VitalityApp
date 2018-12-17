using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.Logic.FoodSystem;
using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace TeamBoss.GAC.Vitality.LogicFactory
{
    public class FoodUserFactory
    {
        /// <summary>
        /// Returns a new IFoodUser interface.
        /// </summary>
        /// <returns></returns>
        public static IFoodUser CreateFoodUserInterface()
        {
            return new FoodUser();
        }
    }
}
