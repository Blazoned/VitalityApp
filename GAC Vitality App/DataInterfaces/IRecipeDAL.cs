using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.DALInterfaces
{
    public interface IRecipeDAL
    {
        List<RecipeStruct> GetRecipeListByUserID(int userID);
    }
}
