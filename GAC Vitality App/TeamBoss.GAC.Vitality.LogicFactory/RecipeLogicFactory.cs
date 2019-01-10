using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.Logic;
using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace TeamBoss.GAC.Vitality.LogicFactory
{
    public class RecipeLogicFactory
    {
        /// <summary>
        /// Returns a new IRecipeLogic interface.
        /// </summary>
        /// <returns></returns>
        public static IRecipeLogic CreateRecipeLogicInterface()
        {
            return new Recipe();
        }
    }
}
