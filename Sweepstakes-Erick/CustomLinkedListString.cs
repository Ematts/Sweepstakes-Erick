using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Erick
{
    class CustomLinkedListString : ICustomString
    {
        CustomLinkedList<char> manipulatedCustom = new CustomLinkedList<char>();
        CNode<char> head;
        public CustomLinkedListString(string manipulatedString)
        {
            stringToCustomLinkedCharList(manipulatedString);
        }
        public void stringToCustomLinkedCharList(string manString)
        {
            manipulatedCustom.AddFirst(manString.ElementAt(0));
            head = manipulatedCustom.First;
            for (int i = 1; i < manString.Length; i++)
            {
                manipulatedCustom.AddAfter(head, manString.ElementAt(i));
                head = head.Next;
            }

        }
        public override string ToString()
        {
            string manString = null;
            head = manipulatedCustom.First;
            for (int i = 0; i < manipulatedCustom.Count(); i++)
            {
                manString += head.Value;
                head = head.Next;
            }

            return manString;
        }
        public void Insert(int startIndex, string stringToInsert)
        {

            int count = 0;
            head = manipulatedCustom.First;
            for (int i = 0; i < manipulatedCustom.Count(); i++)
            {
                if (i >= startIndex - 1 && count < stringToInsert.Length)
                {
                    manipulatedCustom.AddAfter(head, stringToInsert.ElementAt(count));
                    count++;
                }
                head = head.Next;
            }

        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            int count2 = 0;
            head = manipulatedCustom.First;
            for (int i = 0; i < manipulatedCustom.Count(); i++)
            {
                CNode<char> next;
                next = head.Next;
                while (i >= startIndex - 1 && count2 < numCharsToRemove)
                {
                    CNode<char> nextNext;
                    nextNext = next.Next;
                    manipulatedCustom.Remove(next);
                    next = nextNext;
                    count2++;
                }
                head = head.Next;

            }
        }
        public int Length()
        {
            return manipulatedCustom.Count();
        }
    }
}



