using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.DALInterfaces
{
    public struct RecipeStruct
    {
        public int Id { get; private set; }
        public int PersonAmount { get; private set; }
        /// <summary>
        /// The preperation time for the recipe, in Minutes.
        /// </summary>
        public int PreperationTime { get; private set; }
        public int TotalCalories { get; private set; }
        public List<AllergeneStruct> AllergeneList { get; private set; }
        public List<ReactionStruct> ReactionList { get; private set; }
        public List<string> ImageList { get; private set; }
        public List<string> IngredientList { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }
        public string Username { get; private set; }

        public RecipeStruct(int id, int personAmount, int preperationTime, int totalCalories, List<AllergeneStruct> allergeneList, List<ReactionStruct> reactionList, List<string> imageList, List<string> ingredientList, string description, string name, string username)
        {
            Id = id;
            PersonAmount = personAmount;
            PreperationTime = preperationTime;
            TotalCalories = totalCalories;
            AllergeneList = allergeneList;
            ReactionList = reactionList;
            ImageList = imageList;
            IngredientList = ingredientList;
            Description = description;
            Name = name;
            Username = username;
        }
    }
}
