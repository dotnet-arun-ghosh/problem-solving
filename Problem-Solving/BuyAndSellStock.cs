namespace Problem_Solving
{
    public class BuyAndSellStock
    {
        //public static int MaxProfit(int[] prices)
        //{
        //    if (prices == null)
        //    {
        //        return 0;
        //    }
        //    int len = prices.Length;
        //    if (len < 2)
        //    {
        //        return 0;
        //    }
        //    int min = prices[0];
        //    int max = prices[prices.Length - 1];
        //    int i = 1;
        //    int j = len - 2;
        //    int minIndex = 0;
        //    int maxIndex = len - 1;


        //    while (i < maxIndex || j > minIndex)
        //    {
        //        if (i < len && prices[i] < min)
        //        {
        //            min = prices[i];
        //            minIndex = i;
        //        }

        //        if (j > minIndex && prices[j] > max)
        //        {
        //            max = prices[j];
        //            maxIndex = j;
        //        }
        //        i++;
        //        j--;
        //    }

        //    int profit = max - min;

        //    return profit < 0 ? 0 : profit;
        //}

        public static int MaxProfit(int[] prices)
        {
            if (prices == null)
            {
                return 0;
            }
            int len = prices.Length;
            if (len < 2)
            {
                return 0;
            }

            int min = prices[0];
            int max = prices[1];
            int profit = max - min;

            int i = 1;

            // 5 32 4 29 1 9
            // 0 1 2 3 4 5
            while (i+1< len)
            {
                if(prices[i]< min)
                {
                    min = prices[i];
                    max = prices[i + 1];
                }
                else if(prices[i+1] > max)
                {
                    max = prices[i + 1];
                }

                var tmpProfit = max - min;

                if (profit < tmpProfit)
                {
                    profit = tmpProfit;
                }
                i++;
            }
            return profit < 0 ? 0 : profit;
        }
    }
}
