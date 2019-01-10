using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBoss.GAC.Vitality.LogicInterfaces
{
    public interface IReactionLogic
    {
        string Username { get; set; }
        string Message { get; set; }

        bool SetProperties();
    }
}
