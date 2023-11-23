using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadStudy
{
    internal interface IthreadKiller
    {
        bool ThreadKill();
        void ThreadAbort();
    }
}
