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
        private string username { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private List<Allergene> allergenList { get; set; }
        private List<string> ingredientList { get; set; }
        private int preperationTime { get; set; }
        private int totalCalories { get; set; }
        private List<string> imageList { get; set; }
        private int personAmount { get; set; }
        private List<Reaction> reactionList { get; set;}

        public Recipe(RecipeStruct recipeStruct)
        {
            username = recipeStruct.Username;
            name = recipeStruct.Name;
            description = recipeStruct.Description;

            allergenList = new List<Allergene>();
            recipeStruct.AllergeneList.ForEach(allergene => allergenList.Add(new Allergene(allergene)));

            ingredientList = recipeStruct.IngredientList;
            preperationTime = recipeStruct.PreperationTime;
            totalCalories = recipeStruct.TotalCalories;
            imageList = recipeStruct.ImageList;
            personAmount = recipeStruct.PersonAmount;

            reactionList = new List<Reaction>();
            recipeStruct.ReactionList.ForEach(reaction => reactionList.Add(new Reaction(reaction))); 
        }
    }
}
