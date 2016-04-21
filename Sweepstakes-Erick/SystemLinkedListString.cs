using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Erick
{
    class SystemLinkedListString : ICustomString
    {
        LinkedList<char> manipulatedLinkedList = new LinkedList<char>();
        LinkedListNode<char> head;
        public SystemLinkedListString(string manipulatedString)
        {
            stringToLinkedCharList(manipulatedString);
        }
        public void stringToLinkedCharList(string manString)
        {
            manipulatedLinkedList.AddFirst(manString.ElementAt(0));

            head = manipulatedLinkedList.First;
            for (int i = 1; i < manString.Length; i++)
            {
                manipulatedLinkedList.AddAfter(head, manString.ElementAt(i));
                head = head.Next;
            }

        }
        public override string ToString()
        {
            string manString = null;
            head = manipulatedLinkedList.First;
            for (int i = 0; i < manipulatedLinkedList.Count; i++)
            {
                manString += head.Value;
                head = head.Next;
            }

            return manString;
        }
        public void Insert(int startIndex, string stringToInsert)
        {

            int count = 0;
            head = manipulatedLinkedList.First;
            for (int i = 0; i < manipulatedLinkedList.Count; i++)
            {
                if (i >= startIndex - 1 && count < stringToInsert.Length)
                {
                    manipulatedLinkedList.AddAfter(head, stringToInsert.ElementAt(count));
                    count++;
                }
                head = head.Next;
            }

        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            int count2 = 0;
            head = manipulatedLinkedList.First;
            for (int i = 0; i < manipulatedLinkedList.Count; i++)
            {
                LinkedListNode<char> next;
                next = head.Next;
                while (i >= startIndex - 1 && count2 < numCharsToRemove)
                {
                    LinkedListNode<char> nextNext;
                    nextNext = next.Next;
                    manipulatedLinkedList.Remove(next);
                    next = nextNext;
                    count2++;
                }
                head = head.Next;

            }
        }
        public int Length()
        {
            return manipulatedLinkedList.Count;
        }
    }
}




