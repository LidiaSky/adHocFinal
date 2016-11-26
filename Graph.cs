using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adHoc
{

    public class Graph
    {
        private float deg;

        private const int inf = 100000;
        private int n;
        public Graph(int vertexCount)
        {
            n = vertexCount;
        }
        //заменить на ф-цию определения числа компонент связности
        private bool[] used;
        void dfs(List<int> compCurrent, int[][] G, int v,bool[] used)
        {
            used[v] = true;
            compCurrent.Add(v);
            for (int i = 0; i < G[v].Count(); ++i)
            {
                int to = G[v][i];
                if (!used[to])
                {
                    dfs(compCurrent, G, to,used);
                }
            }
        }

        public int ComponentCount(int[][] G)
        {
            List<int> compCurrent = new List<int>(); // текущая компонента 
            int res = 0; // кол-во компонент 
            bool[] used = new bool[G.Count()];
            int n = G.Count();
            for (int i = 0; i < n; ++i)
                used[i] = false;
            for (int i = 0; i < n; ++i)
                if (!used[i])
                {
                    compCurrent.Clear();
                    dfs(compCurrent, G, i,used);
                    res++;
                }
            return res;
        }
    }
}
