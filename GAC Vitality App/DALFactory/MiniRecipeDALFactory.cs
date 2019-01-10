using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DAL;
using TeamBoss.GAC.Vitality.DALInterfaces;

namespace TeamBoss.GAC.Vitality.DALFactory
{
    public class MiniRecipeDALFactory
    {
        public static IMiniRecipeDAL CreateMiniRecipeDALInterface()
        {
            return new MiniRecipeDAL();
        }
    }
}
