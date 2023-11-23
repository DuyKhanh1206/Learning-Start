using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Class1
    {
        public string sample(decimal value1, decimal value2,Func<decimal, decimal, string> calcfunc)
        {
            string sRerurnValue = calcfunc(value1, value2);
            return sRerurnValue;
        }
    }
}
