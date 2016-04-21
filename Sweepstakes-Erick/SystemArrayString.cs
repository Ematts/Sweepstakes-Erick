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
            char[] newCharsArray1 = makeNewArrayAt(0, startIndex, manipulatedCharArray);
            char[] newCharsArray2 = makeNewArrayAt(startIndex, manipulatedCharArray.Length, manipulatedCharArray);
            char[] insertedCharsArray = stringToInsert.ToCharArray();
            char[][] arrays = new char[][] { newCharsArray1, insertedCharsArray, newCharsArray2 };
            addArrays(arrays);
            manipulatedCharArray = addArrays(arrays);
        }
        public void Remove(int startIndex, int numCharsToRemove)
        {
            int startIndex2 = startIndex + numCharsToRemove + 1;
            char[] newCharsArray1 = makeNewArrayAt(0, startIndex, manipulatedCharArray);
            char[] newCharsArray2 = makeNewArrayAt(startIndex2, manipulatedCharArray.Length, manipulatedCharArray);
            char[][] arrays = new char[][] { newCharsArray1, newCharsArray2 };
            addArrays(arrays);
            manipulatedCharArray = addArrays(arrays);
        }
        public int Length()
        {
            return manipulatedCharArray.Length;
        }
        public char[] makeNewArrayAt(int startIndex, int endIndex, char[] arrayToTakePortion)
        {
            int lengthA = endIndex - startIndex;
            char[] newCharA = new char[0];
            if (endIndex > startIndex)
            {
                newCharA = new char[lengthA];
            }
            for (int i = startIndex; i < endIndex; i++)
            {
                newCharA[i - startIndex] = manipulatedCharArray.ElementAt(i);
            }
            return newCharA;
        }
        public char[] addArrays(char[][] arrays)
        {
            char[] finalCharA = new char[FindTotalLength(arrays)];
            int count = 0;
            for (int j = 0; j < arrays.Length; j++)
            {
                for (int i = 0; i < arrays[j].Length; i++)
                {
                    finalCharA[count] = arrays[j].ElementAt(i);
                    count++;
                }
            }
            return finalCharA;
        }
        public int FindTotalLength(char[][] arrays)
        {
            int lengthA = 0;

            foreach (char[] array in arrays)
            {
                lengthA += array.Length;
            }
            return lengthA;
        }

    }
}
    
