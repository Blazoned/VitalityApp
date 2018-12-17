using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.Logic.FoodSystem;
using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace TeamBoss.GAC.Vitality.LogicFactory
{
    public class FoodUserLogicFactory
    {
        /// <summary>
        /// Returns a new IFoodUserLogic interface.
        /// </summary>
        /// <returns></returns>
        public static IFoodUserLogic CreateFoodUserLogicInterface()
        {
            return new FoodUser();
        }
    }
}
