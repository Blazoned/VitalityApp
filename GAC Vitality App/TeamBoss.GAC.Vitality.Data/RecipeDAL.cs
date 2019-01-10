using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALInterfaces;

namespace TeamBoss.GAC.Vitality.DAL
{
    public class RecipeDAL : IRecipeDAL
    {
        public List<RecipeStruct> GetRecipeListByUserID(int userID)
        {
            Connection connection = new Connection();

            connection.Open();
            DataTable table = connection.ExecuteReader("SELECT * FROM Recipe" +
                " INNER JOIN [User] ON Recipe.UserCreatorId = [User].Id" +
                " WHERE UserCreatorId = " + userID);
            connection.Close();

            List<RecipeStruct> returnList = new List<RecipeStruct>(table.Rows.Count);
            foreach (DataRow row in table.Rows)
            {
                int recipeID = (int)row["Id"];
                int personAmount = (int)row["TotalPersonAmount"];
                int preperationTime = (int)row["PreperationTime"];
                int totalCalories = (int)row["TotalCalorieAmount"];

                connection.Open();
                DataTable allergeneTable = connection.ExecuteReader("SELECT * FROM RecipeAllergene" +
                    " INNER JOIN Allergenes ON RecipeAllergene.AllergeneId = Allergenes.Id" +
                    " WHERE RecipeId = " + recipeID);
                DataTable reactionTable = connection.ExecuteReader("SELECT * FROM Reaction WHERE RecipeId = " + recipeID);
                DataTable imageTable = connection.ExecuteReader("SELECT * FROM Image WHERE RecipeId = " + recipeID);
                DataTable ingredientTable = connection.ExecuteReader("SELECT * FROM Ingredients WHERE RecipeId = " + recipeID);
                connection.Close();

                List<AllergeneStruct> allergeneList = new List<AllergeneStruct>(allergeneTable.Rows.Count);
                foreach (DataRow allergeneRow in allergeneTable.Rows)
                {
                    int allergeneID = (int)allergeneRow["AllergeneId"];
                    string allergeneName = (string)allergeneRow["Name"];

                    allergeneList.Add(new AllergeneStruct(allergeneID, allergeneName)); 
                }
                List<ReactionStruct> reactionList = new List<ReactionStruct>(reactionTable.Rows.Count);
                foreach (DataRow reactionRow in reactionTable.Rows)
                {
                    reactionList.Add(new ReactionStruct(reactionRow["Desciption"].ToString(), reactionRow["Username"].ToString()));
                }
                List<string> imageList = new List<string>(imageTable.Rows.Count);
                foreach (DataRow imageRow in imageTable.Rows)
                {
                    imageList.Add(imageRow["FilePath"].ToString());
                }
                List<string> ingredientList = new List<string>(ingredientTable.Rows.Count);
                foreach (DataRow ingredientRow in ingredientTable.Rows)
                {
                    ingredientList.Add(ingredientRow["Name"].ToString());
                }

                string description = row["Description"].ToString();
                string name = row["Name"].ToString();
                string creatorUsername = (string)row["Name1"];

                returnList.Add(new RecipeStruct(recipeID, personAmount, preperationTime, totalCalories, allergeneList, reactionList, imageList, ingredientList, description, name, creatorUsername));
            }

            return returnList;
        }
    }
}