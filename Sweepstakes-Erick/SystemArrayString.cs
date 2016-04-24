using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Erick
{
    class SystemArrayString : ICustomString
    {
        char[] manipulatedCharArray;

        public SystemArrayString(string manipulatedString)
        {
            manipulatedCharArray = manipulatedString.ToCharArray();
        }
        public override string ToString()
        {
            string finalString = null;
            foreach (char character in manipulatedCharArray)
            {
                finalString += character;
            }
            return finalString;
        }
        public void Insert(int startIndex, string stringToInsert)
        {
            char[] temporaryArray = new char[manipulatedCharArray.Count() + stringToInsert.Count()];
            int i = 0;
            int j = 0;
            for (int TemporaryIndex = 0; TemporaryIndex < manipulatedCharArray.Count() + stringToInsert.Count(); TemporaryIndex++)
            {
                if (TemporaryIndex >= startIndex && TemporaryIndex < startIndex + stringToInsert.Count())
                {
                    temporaryArray[TemporaryIndex] = stringToInsert.ElementAt(i);
                    i++;
                }
                else
                {
                    temporaryArray[TemporaryIndex] = manipulatedCharArray[j];
                    j++;
                }
            }
            manipulatedCharArray = temporaryArray;
        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            char[] ShortenedString = new char[manipulatedCharArray.Count() - numCharsToRemove];
            int i;
            for (i = 0; i < startIndex; i++)
            {
                ShortenedString[i] = manipulatedCharArray[i];
            }
            for (int j = startIndex + numCharsToRemove; j < manipulatedCharArray.Count(); j++)
            {
                ShortenedString[i] = manipulatedCharArray[j];
                i++;
            }
            manipulatedCharArray = ShortenedString;
        }
        public int Length()
        {
            int Length = manipulatedCharArray.Count();
            return Length;
        }
    }
}
