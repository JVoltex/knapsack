using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knapsack
{
    class Program
    {
        static int MAXWEIGHT = 10;
        static int SHINAMAXWEIGHT = 10;
        static int SHINAMAXVALUE = 5;
        static int SHINANUM = 20;

        static void Main(string[] args)
        {
            KnapsackProbrem kp = KnapsackProbrem.MakeProblem(MAXWEIGHT, SHINAMAXWEIGHT, SHINAMAXVALUE, SHINANUM);
            KPSolver s_dfs = new DFS(kp);
            KPSolver s_mem = new Memorization(kp);
            KPSolver s_dyn = new DP(kp);
        }
    }
}
