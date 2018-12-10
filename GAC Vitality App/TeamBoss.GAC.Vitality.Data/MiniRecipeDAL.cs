using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DataInterfaces;

namespace TeamBoss.GAC.Vitality.Data
{
    public class MiniRecipeDAL : IMiniRecipeDAL
    {
        public List<MiniRecipeStruct> GetAllMiniRecipesByUserID(int userID, bool useTestDatabase = false)
        {
            Connection connection = new Connection(useTestDatabase);
            connection.Open();
            DataTable dataTable = connection.ExecuteReader("SELECT * FROM [MiniRecipe] WHERE UserId = " + userID);
            connection.Close();

            List<MiniRecipeStruct> returnList = new List<MiniRecipeStruct>();
            foreach (DataRow row in dataTable.Rows)
            {
                int calorieAmount = (int)row["CalorieAmount"];
                string name = (string)row["Name"];

                returnList.Add(new MiniRecipeStruct(calorieAmount, name));
            }

            return returnList;
        }
    }
}
