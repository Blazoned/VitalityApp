using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALInterfaces;
using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Recipe : IRecipeLogic
    {
        /*private string username { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private List<Allergene> allergenList { get; set; }
        private List<string> ingredientList { get; set; }
        private int preperationTime { get; set; }
        private int totalCalories { get; set; }
        private List<string> imageList { get; set; }
        private int personAmount { get; set; }
        private List<Reaction> reactionList { get; set;}

        public Recipe() { }

        public void SetProperties(RecipeStruct recipeStruct)
        {
            username = recipeStruct.Username;
            name = recipeStruct.Name;
            description = recipeStruct.Description;

            allergenList = new List<Allergenes>();
            // TODO: Make it so the struct is correctly loaded into the list.
            recipeStruct.AllergeneList.ForEach(allergene => allergenList.Add(new Allergenes()));

            ingredientList = recipeStruct.IngredientList;
            preperationTime = recipeStruct.PreperationTime;
            totalCalories = recipeStruct.TotalCalories;
            imageList = recipeStruct.ImageList;
            personAmount = recipeStruct.PersonAmount;

            reactionList = new List<Reaction>();
            // TODO: Make it so the reaction structs are loaded into the reactions.
            recipeStruct.ReactionList.ForEach(reaction => reactionList.Add(new Reaction()));
        }*/

        public int PreperationTime { get; set; }
        public int TotalCalories { get; set; }
        public int ServingsCount { get; set; }
        public List<IReactionLogic> Reactions { get; set; }
        public List<string> ImageLinks { get; set; }
        public List<string> Ingredients { get; set; }
        public string CreatorName { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public void SetProperties()
        {
            throw new NotImplementedException();
        }
    }
}
