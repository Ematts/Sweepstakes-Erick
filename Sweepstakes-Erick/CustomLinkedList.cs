using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Erick
{
    class CustomLinkedList<T>
    {
        CNode<T> Head;
        CNode<T> first;
        CNode<T> last;

        public CustomLinkedList()
        {
            Head = null;
        }
        public CNode<T> First
        {
            get
            {
                return first;
            }
        }
        public CNode<T> Last
        {
            get
            {
                return last;
            }
        }

        //public void addHead(T cValue)
        //{
        //    CNode<T> temp = new CNode<T>(cValue);
        //    temp.Next = head;
        //    head = temp;
        //}
        public void AddLast(T cValue)
        {
            CNode<T> temp = new CNode<T>(cValue);
            if (Head == null)
            {
                Head = temp;
            }
            else
            {
                while (Head.Next != null)
                {
                    temp = temp.Next;
                }
            }
            last = temp;
        }
        public void AddFirst(T cValue)
        {
            CNode<T> temp = new CNode<T>(cValue);
            if (Head == null)
            {
                Head = temp;
            }
            while (Head.Last != null)
            {
                temp = temp.Last;
            }
            first = temp;
        }
        public void AddBefore(CNode<T> current, T cValue)
        {
            CNode<T> temp = new CNode<T>(cValue);
            CNode<T> temp2;
            temp2 = current.Last;
            current.Last = temp;
            temp.Last = temp2;
            temp.Next = current;
        }
        public void AddAfter(CNode<T> current, T cValue)
        {
            CNode<T> temp = new CNode<T>(cValue);
            CNode<T> temp2;
            temp2 = current.Next;
            current.Next = temp;
            temp.Next = temp2;
            temp.Last = current;

        }
        public void Remove(CNode<T> current)
        {
            current.Next.Last = current.Last;
            current.Last.Next = current.Next;
            current = null;
        }
        public int Count()
        {
            int count;
            int loopcount = 0;
            CNode<T> headholder = Head;
            for (int i = 0; headholder != null; i++)
            {
                headholder = headholder.Next;
                loopcount++;
            }
            count = loopcount;
            return count;
        }
    }
}




