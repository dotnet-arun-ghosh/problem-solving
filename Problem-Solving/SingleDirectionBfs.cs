using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class SingleDirectionBfs
    {

        public static int GetSingleDirectionShortestPath(int numberOfNode, int[][] connection, int nodeToStart, int nodeToFind)
        {
            List<int> queue = new List<int>();
            bool[] visisted = new bool[numberOfNode];
            int[] distance = new int[numberOfNode];
            queue.Add(nodeToStart);
            visisted[nodeToStart] = true;
            distance[nodeToStart] = 0;
            List<int>[] nodeConnection = new List<int>[numberOfNode];

            for (int i = 0; i < connection.Length; i++)
            {
                var router = connection[i][0];
                var con = connection[i][1];

                if (nodeConnection[router] == null)
                    nodeConnection[router] = new List<int>();

                nodeConnection[router].Add(con);
            }

            while (queue.Count != 0)
            {
                int currindex = queue[0];
                queue.RemoveAt(0);

                for (int i = 0; i < nodeConnection[currindex]?.Count; i++)
                {
                    if (!visisted[nodeConnection[currindex][i]])
                    {
                        queue.Add(nodeConnection[currindex][i]);
                        visisted[nodeConnection[currindex][i]] = true;
                        distance[nodeConnection[currindex][i]] = distance[currindex] + 1;
                        if (nodeConnection[currindex][i] == nodeToFind)
                            return distance[nodeToFind];
                    }
                }
            }
            return -1;
        }
    }
}
