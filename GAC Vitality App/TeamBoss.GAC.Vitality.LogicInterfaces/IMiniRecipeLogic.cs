﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.LogicInterfaces
{
    public interface IMiniRecipeLogic
    {
        int TotalCalories { get; set; }
        string Name { get; set; }

        bool SetProperties();
    }
}
