using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Erick
{
    class SystemString : ICustomString
    {
        string StringToManipulate;
        public SystemString(string inputString)
        {
            StringToManipulate = inputString;
        }
        public override string ToString()
        {
            return StringToManipulate;
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            StringToManipulate.Insert(startIndex, stringToInsert);
        }

        
    }

}
