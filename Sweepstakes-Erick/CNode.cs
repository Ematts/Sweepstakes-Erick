using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Erick
{
    class CNode<T>
    {
        CNode<T> next;
        CNode<T> last;
        T cValue;

        public CNode(T CValue)
        {
            cValue = CValue;
            next = null;
            last = null;
        }
        public CNode<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
        public CNode<T> Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }
        public T Value
        {
            get
            {
                return cValue;
            }
            set
            {
                cValue = value;
            }
        }


    }
}




