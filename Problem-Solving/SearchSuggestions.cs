using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class SearchSuggestions
    {

        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);
            string searchString = string.Empty;
            IList<IList<string>> suggestion = new List<IList<string>>();

            for (int i = 0; i < searchWord.Length; i++)
            {
                suggestion.Add(new List<string>());
                searchString += searchWord[i];
                for (int j  = 0; j < products.Length; j++)
                {
                    if (suggestion[i].Count == 3)
                        break;
                    if (products[j].StartsWith(searchString))
                    {
                        suggestion[i].Add(products[j]);
                    }
                }
            }
            return suggestion;
        }
    }
}
