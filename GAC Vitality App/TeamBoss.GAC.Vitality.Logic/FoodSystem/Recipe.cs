using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALInterfaces;
using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Recipe 
    {
        public int Id { get; set; }
        public int PreperationTime { get; set; }
        public int TotalCalories { get; set; }
        public int ServingsCount { get; set; }
        public List<Reaction> Reactions { get; set; }
        public List<string> ImageLinks { get; set; }
        public List<string> Ingredients { get; set; }
        public string CreatorName { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int TotalFavorites { get; set; }

        public Recipe(int id, int preperationTime, int totalCalories, int servingsCount, List<Reaction> reactions, List<string> imageLinks, List<string> ingredients, string creatorName, string description, string name, int totalFavorites)
        {
            Id = id; 
            PreperationTime = preperationTime;
            TotalCalories = totalCalories;
            ServingsCount = servingsCount;
            Reactions = reactions;
            ImageLinks = imageLinks;
            Ingredients = ingredients;
            CreatorName = creatorName;
            Description = description;
            Name = name;
            TotalFavorites = totalFavorites; 
        }
    }
}
