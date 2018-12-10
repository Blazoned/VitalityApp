using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.Structs;

namespace TeamBoss.GAC.Vitality.DataInterfaces
{
    public interface IRecipeDAL
    {
        List<RecipeStruct> GetRecipeListByUserID(int userID, bool useTestDatabase = false);
    }
}
