using System;

namespace Problem_Solving
{
    public class NonRepeatingFirstCharcter
    {
        /// <summary>
        /// This method will return first non repeating character from the string
        /// Complexity is O(n)
        /// </summary>
        /// <param name="str">Should be all lower case as we are subtracting from lower case ASCII value</param>
        /// <returns>Empty character or the first non repeating character</returns>
        public static char GetNonRepeatingFirstCharacter(string str)
        {
            char firstNonRepeatingChar = default(char);
            if(!string.IsNullOrWhiteSpace(str))
            {
                // as we are dealing with lowercase letter and array index is starting from ZERO
                // we are taking the ASCII value of character 'a' which is 97 
                // so that we can assign if the character is 'a' we can assign to the index zero of array.
                int asciiOfinitialChar = 'a';

                // array index 26 as we have only 26 alphabet. 
                int[] alphabetArray = new int[26];

                // loop through the string provided. 
                // O(n) as it loops till the length of the array.
                foreach (var ch in str)
                {
                    // checking if the array contains only lowercase character else throw format exception.
                    if (ch < 97 || ch > 122)
                    {
                        throw new FormatException("Given string contain non lowercase alphabet");
                    }

                    // subtracting with 97 so we can assign 'a' to index 0 and b to index 1 so on..
                    var index = ch - asciiOfinitialChar;
                    // incrementing the count so that we can get to know how many character is there in a string
                    alphabetArray[ch - asciiOfinitialChar]++;
                }

                // fixed looping, can be considered as O(1) as it is always loop 26 times irrespective of length of the array
                for (int i = 0; i < 26; i++)
                {
                    //finding first non repeating character as we have count of the characters in the alphabetArray
                    if (alphabetArray[i] == 1)
                    {
                        // converting to character by adding the asciiOfinitialChar 97 
                        // so that we will get if the index is 1 then 1 + 97 = 98  which is the ASCII vale of character 'b'
                        // break the loop as we found first non repeating character
                        firstNonRepeatingChar = (char)(i + asciiOfinitialChar);
                        break;
                    }
                }


            }

            return firstNonRepeatingChar;
        }
    }
}
