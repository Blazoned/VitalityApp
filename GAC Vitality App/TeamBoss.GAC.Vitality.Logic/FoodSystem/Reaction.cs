using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.Logic
{
    public class Reaction 
    {
        public string Username { get; set; }
        public string Message { get; set; }

        public Reaction(string username, string message)
        {
            Username = username;
            Message = message; 
        }
    }
}
