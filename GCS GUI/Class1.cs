using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCCS_GUI
{
    class Class1
    {
        static string nm;
        public static string Decider
        {
            get
            {
                return nm;
            }
            set
            {
                nm = value;
            }
        }
        
    }
}

