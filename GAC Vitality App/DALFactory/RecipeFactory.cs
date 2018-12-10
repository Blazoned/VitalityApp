using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.Data;
using TeamBoss.GAC.Vitality.DataInterfaces;

namespace TeamBoss.GAC.Vitality.DALFactory
{
    public class RecipeFactory
    {
        public static IRecipeDAL CreateRecipeInterface()
        {
            return new RecipeDAL();
        }
    }
}
