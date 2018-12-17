using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TeamBoss.GAC.Vitality.DALInterfaces;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Allergene
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Allergene(int id, string name)
        {
            Id = id;
            Name = name; 
        }

        public Allergene(AllergeneStruct allergeneStruct)
        {
            Id = allergeneStruct.Id;
            Name = allergeneStruct.Name; 
        }

    }
}
