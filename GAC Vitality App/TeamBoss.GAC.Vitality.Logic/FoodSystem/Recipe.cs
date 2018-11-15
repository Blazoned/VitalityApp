using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic.FoodSystem
{
    public class Recipe
    {
        private string username { get; set; }
        private string name { get; set; }
        private string description { get; set; }
        private List<Allergenes> allergenList { get; set; }
        private List<string> ingredientList { get; set; }
        private int preperationTime { get; set; }
        private int totalCalories { get; set; }
        private List<string> imageList { get; set; }
        private int personAmount { get; set; }
        private List<Reaction> reactionList { get; set;}
    }
}
