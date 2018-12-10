﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.DataInterfaces
{
    public interface IMiniRecipeDAL
    {
        List<MiniRecipeStruct> GetAllMiniRecipesByUserID(int userID, bool useTestDatabase = false);
    }
}