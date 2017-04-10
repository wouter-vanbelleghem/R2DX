using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R2DX.Common
{
    public enum AIState
    {
        Unknown = -1,
        Stopped = 0,
        Starting = 1,
        Started = 2,
        Stopping = 3,
        Listening = 4,
        Acting = 5,
        Searching = 6,
        Learning = 7,
        Error = 8,
        Question = 9
    };

    public class Functions
    {
        public AIState getAIState()
        {
            AIState tmp = AIState.Unknown;

            return tmp;
        }

        public void log()
        {
            //log internally on mysql database (so compatible with Rasberry and linux)
            //-- when log server (server) is reachable, synchronize?
            //log service syncronizator must be seperate service?
        }
    }       
}
