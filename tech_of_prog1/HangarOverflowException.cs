using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_of_prog1
{
    class HangarOverflowException : Exception
    {
        public HangarOverflowException() : base("В ангаре нет свободных мест")
        { }
    }
}
