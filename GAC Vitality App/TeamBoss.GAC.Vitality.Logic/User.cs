﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class User
    {
        protected int Id { get; private set; }

        public User() { }

        public void SetID(int id)
        {
            Id = id; 
        }
    }
}
