using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class TopKFrequentlyMentionedKeyword
    {

        public static string[] GetFrequentlyMentionedKeyword(int k, string[] keyWords, string[] reviews)
        {
            Dictionary<string, int> keyWordCount = new Dictionary<string, int>();

            Array.Sort(keyWords);

            foreach (var review in reviews)
            {
                foreach (var keyword in keyWords)
                {
                    var key = keyword.ToLower();
                    if (review.ToLower().Contains(key))
                    {
                        if(keyWordCount.ContainsKey(key))
                        {
                            keyWordCount[key]++;
                        }
                        else
                        {
                            keyWordCount.Add(key, 1);
                        }
                    }
                }
            }

            var response = new string[k];
            int i = 0;
            foreach (var item in keyWordCount.OrderByDescending(x => x.Value))
            {
                response[i] = item.Key;
                i++;
                if (i == k)
                    break;
            }
            return response;
        }

    }
}
