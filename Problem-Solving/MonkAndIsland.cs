using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class MonkAndIsland
    {

        //public static int GetShortestPath(int numberofNode, List<int>[] connection)
        //{
        //    List<int> queue = new List<int>();
        //    bool[] visisted = new bool[numberofNode];
        //    int[] distance = new int[numberofNode];
        //    queue.Add(connection[0][0]);
        //    visisted[connection[0][0]] = true;
        //    distance[connection[0][0]] = 0;


        //}
        public static int GetShortestPath(int numberOfNode, int[][] connection)
        {
            List<int> queue = new List<int>();
            int nodeToFind = numberOfNode;
            bool[] visisted = new bool[numberOfNode];
            int[] distance = new int[numberOfNode];
            queue.Add(1);
            visisted[0] = true;
            distance[0] = 0;
            List<int>[] nodeConnection = new List<int>[numberOfNode];

            for (int i = 0; i < connection.Length; i++)
            {
                var router = connection[i][0];
                var con = connection[i][1];

                if (nodeConnection[router-1] == null)
                    nodeConnection[router-1] = new List<int>();
                if (nodeConnection[con-1] == null)
                    nodeConnection[con-1] = new List<int>();

                nodeConnection[con-1].Add(router);
                nodeConnection[router-1].Add(con);
            }

            while (queue.Count != 0)
            {
                int currindex = queue[0] - 1;
                queue.RemoveAt(0);

                for (int i = 0; i < nodeConnection[currindex].Count; i++)
                {
                    if(!visisted[nodeConnection[currindex][i]-1])
                    {
                        queue.Add(nodeConnection[currindex][i]);
                        visisted[nodeConnection[currindex][i]-1] = true;
                        distance[nodeConnection[currindex][i] - 1] = distance[currindex] + 1;
                        if (nodeConnection[currindex][i] == nodeToFind)
                            return distance[nodeToFind - 1];
                    }
                }
            }
            return -1;
        }

    }
}
