using System;
using System.Collections.Generic;

namespace Problem_Solving
{
    public class CriticalRouter
    {
        private static List<int>[] graph;
        private static List<int[]> criticalConnection;
        private static IList<IList<int>> criticalCon;
        private static int[] discoveryTime;
        private static int[] lowTime;
        private static bool[] isVisited;
        private static int times;

        public static List<int[]> GetCriticalRouter(int nodes, int[][] connection )
        {
            graph = new List<int>[nodes];
            criticalConnection = new List<int[]>();
            discoveryTime = new int[nodes];
            lowTime = new int[nodes];
            isVisited = new bool[nodes];
            times = 0;

            for (int i = 0; i < connection.Length; i++)
            {
                var router = connection[i][0];
                var con = connection[i][1];
                if (graph[router] == null)
                    graph[router] = new List<int>();
                if (graph[con] == null)
                    graph[con] = new List<int>();

                graph[router].Add(con);
                graph[con].Add(router);
            }

            Dfs(isVisited, 0, -1);

            return criticalConnection;
        }

        private static void Dfs(bool[] isVisited, int currNode, int parentNode)
        {
            isVisited[currNode] = true;
            discoveryTime[currNode] = lowTime[currNode] = times++;

            foreach (var nearbyNode in graph[currNode])
            {
                if (nearbyNode == parentNode) continue;
                if (!isVisited[nearbyNode])
                {
                    Dfs(isVisited, nearbyNode, currNode);
                    lowTime[currNode] = Math.Min(lowTime[currNode], lowTime[nearbyNode]);
                    if (discoveryTime[currNode] < lowTime[nearbyNode])
                    {
                        criticalConnection.Add(new int[] { currNode, nearbyNode });
                    }
                }
                else
                {
                    lowTime[currNode] = Math.Min(lowTime[currNode], discoveryTime[nearbyNode]);
                }
            }

        }

        public static IList<IList<int>> CriticalConnections(int n, IList<IList<int>> connections)
        {
            graph = new List<int>[n];
            criticalCon = new List<IList<int>>();
            discoveryTime = new int[n];
            lowTime = new int[n];
            isVisited = new bool[n];
            times = 0;

            for (int i = 0; i < connections.Count; i++)
            {
                var router = connections[i][0];
                var con = connections[i][1];
                if (graph[router] == null)
                    graph[router] = new List<int>();
                if (graph[con] == null)
                    graph[con] = new List<int>();

                graph[router].Add(con);
                graph[con].Add(router);
            }

            DfsN(isVisited, 0, -1);

            return criticalCon;
        }

        private static void DfsN(bool[] isVisited, int currNode, int parentNode)
        {
            isVisited[currNode] = true;
            discoveryTime[currNode] = lowTime[currNode] = times++;

            foreach (var nearbyNode in graph[currNode])
            {
                if (nearbyNode == parentNode) continue;
                if (!isVisited[nearbyNode])
                {
                    DfsN(isVisited, nearbyNode, currNode);
                    lowTime[currNode] = Math.Min(lowTime[currNode], lowTime[nearbyNode]);
                    if (discoveryTime[currNode] < lowTime[nearbyNode])
                    {
                        criticalCon.Add( new List<int>() { currNode, nearbyNode });
                    }
                }
                else
                {
                    lowTime[currNode] = Math.Min(lowTime[currNode], discoveryTime[nearbyNode]);
                }
            }

        }

        
    }

}
