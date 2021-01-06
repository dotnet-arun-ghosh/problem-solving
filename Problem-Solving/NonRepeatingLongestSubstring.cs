using System.Collections.Generic;

namespace Problem_Solving
{
    public class NonRepeatingLongestSubstring
    {

        public static string GetNonRepeatingLongestSubstring(string str)
        {

            if (str.Length == 1)
                return str;

            int i = 0;
            List<char> charArray = new List<char>();
            int startIndex = 0;
            int endIndex = 0;
            int max = 0;

            while (i < str.Length)
            {
                if (i != str.Length - 1 && !charArray.Contains(str[i]))
                {
                    charArray.Add(str[i]);
                }
                else
                {
                   
                    if (max < i - endIndex)
                    {
                        startIndex = endIndex;
                        if (i == str.Length - 1 && !charArray.Contains(str[i]))
                        {
                            max = i - startIndex + 1;

                        }
                        else
                        {
                            max = i - startIndex;

                        }
                    }
                    charArray.Clear();
                    charArray.Add(str[i]);
                    endIndex = i;

                }

                i++;
            }

            return str.Substring(startIndex, max);
        }

    }
}
