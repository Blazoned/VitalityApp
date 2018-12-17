using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.LogicInterfaces
{
    public interface IRecipeLogic
    {
        int PreperationTime { get; set; }
        int TotalCalories { get; set; }
        int ServingsCount { get; set; }
        // List<IAllergenes> Allergens{get;set;}
        List<IReactionLogic> Reactions { get; set; }
        List<string> ImageLinks { get; set; }
        List<string> Ingredients { get; set; }
        string CreatorName { get; set; }
        string Description { get; set; }
        string Name { get; set; }

        void SetProperties();

    }
}
