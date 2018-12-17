using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.Logic;
using TeamBoss.GAC.Vitality.LogicInterfaces;

namespace TeamBoss.GAC.Vitality.LogicFactory
{
    public class CalorieCounterLogicFactory
    {
        public static ICalorieCounterLogic CreateCalorieCounterLogicInterface()
        {
            return new CalorieCounter();
        }
    }
}
