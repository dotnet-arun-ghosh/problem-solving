using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class Bfs
    {
        public static List<int> BfsTraversing(int[][] connection, int numberOfNode)
        {
            var nodeQueue = new List<int>();

            int visitedTime = 1;

            var vistedArray = new bool[numberOfNode];
            var vistedTime = new int[numberOfNode];
            var visitedNode = new List<int>(numberOfNode);

            nodeQueue.Add(connection[0][0]);
            vistedArray[connection[0][0]] = true;
            vistedTime[connection[0][0]] = visitedTime;
            visitedNode.Add(connection[0][0]);

            List<int>[] nodeConnection = new List<int>[numberOfNode];

            for (int i = 0; i < connection.Length; i++)
            {
                var router = connection[i][0];
                var con = connection[i][1];

                if (nodeConnection[router] == null)
                    nodeConnection[router] = new List<int>();
                //if (nodeConnection[con] == null)
                //    nodeConnection[con] = new List<int>();

                nodeConnection[router].Add(con);
                //nodeConnection[con].Add(router);
            }

            while (nodeQueue.Count >0) {
                int i = nodeQueue[0];
                if (nodeConnection[i] == null)
                {
                    nodeQueue.RemoveAt(0);
                    continue;
                }
                for (int j = 0; j < nodeConnection[i].Count; j++)
                {
                    if(!vistedArray[nodeConnection[i][j]])
                    {
                        vistedArray[nodeConnection[i][j]] = true;
                        nodeQueue.Add(nodeConnection[i][j]);
                        vistedTime[nodeConnection[i][j]] = ++visitedTime;
                        visitedNode.Add(nodeConnection[i][j]);
                    }
                }
                nodeQueue.RemoveAt(0);
            }


            return visitedNode;
        }

        public static List<int> DfsTraversing(int[][] connection, int numberOfNode)
        {
            var nodeStack = new List<int>();

            int visitedTime = 1;

            var vistedArray = new bool[numberOfNode];
            var vistedTime = new int[numberOfNode];
            var visitedNode = new List<int>(numberOfNode);

            nodeStack.Add(connection[0][0]);
            vistedArray[connection[0][0]] = true;
            vistedTime[connection[0][0]] = visitedTime;
            visitedNode.Add(connection[0][0]);

            List<int>[] nodeConnection = new List<int>[numberOfNode];

            for (int i = 0; i < connection.Length; i++)
            {
                var router = connection[i][0];
                var con = connection[i][1];

                if (nodeConnection[router] == null)
                    nodeConnection[router] = new List<int>();
                //if (nodeConnection[con] == null)
                //    nodeConnection[con] = new List<int>();

                nodeConnection[router].Add(con);
                //nodeConnection[con].Add(router);
            }

            while (nodeStack.Count > 0)
            {
                int i = nodeStack[nodeStack.Count -1];

                for (int j = 0; j < nodeConnection[i].Count; j++)
                {
                    if(!vistedArray[nodeConnection[i][j]])
                    {
                        nodeStack.Add(nodeConnection[i][j]);
                        vistedArray[nodeConnection[i][j]] = true;
                        vistedTime[nodeConnection[i][j]] = ++visitedTime;
                        visitedNode.Add(nodeConnection[i][j]);
                        break;
                    }
                    if(j== nodeConnection[i].Count-1)
                        nodeStack.RemoveAt(nodeStack.Count - 1);

                }

            }


            return visitedNode;
        }
    }
}
