using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class LongestPalindromicSubString
    {

        public static int GetLongestPalindromicLengthAvailableInPrvidedCharacter(string sentance)
        {

            int[] charArray = new int[26];

            for (int i = 0; i < sentance.Length; i++)
            {
                charArray[sentance[i] - 97]++;
            }

            int stringLength = 0;
            int oddCharCount = 0;
            for (int i = 0; i < 26; i++)
            {
                stringLength += charArray[i] / 2;
                oddCharCount += charArray[i] % 2;
            }

            return stringLength*2 + (oddCharCount > 0 ? 1 : 0);
        }

        //public static string GetLongestPalindromicSubstring(string sentance)
        //{

        //    int start = 0;
        //    int end =0;
        //    for (int i = 0; i < sentance.Length; i++)
        //    {
        //        //int firstPal = GetLengthOfThePalindrom(sentance, i, i);
        //        int secondPal = GetLengthOfThePalindrom(sentance, i, i + 1);
        //        //int palLength = Math.Max(firstPal, secondPal);
        //        int palLength = secondPal;
        //        if(palLength > end-start)
        //        {
        //            start = (i - (palLength) / 2);
        //            end = i + (palLength / 2);
        //        }
        //    }
        //    return sentance.Substring(start, (end - start)+1);
        //}



        public static string GetLongestPalindromicSubstring(string sentance)
        {

            int startIndex = 0;
            int len = 0;
            for (int i = 0; i < sentance.Length; i++)
            {
                if ((len / 2) > sentance.Length - (i +1))
                    break;

                int firstPal = GetLengthOfThePalindrom(sentance, i, i);
                int secondPal = GetLengthOfThePalindrom(sentance, i, i + 1);
                int palLength = firstPal;
                int startBuffer = 0;

                if (secondPal > firstPal)
                {
                    startBuffer = 1;
                    palLength = secondPal;
                }
                if (palLength > len)
                {
                    startIndex = (i - (palLength / 2)) + startBuffer;
                    len = palLength;
                }
            }
            return sentance.Substring(startIndex, len);
        }

        private static int GetLengthOfThePalindrom(string s, int left, int right)
        {
            while(left>=0 && right< s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            var len = right -left - ((right -left) == 2 ? 2 : 1);
            return len;
        }
    }
}
