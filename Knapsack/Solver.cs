using System.Collections.Generic;

namespace Knapsack
{
    internal class Solver
    {
        public readonly KnapsackProbrem kp;
        public int res_value;

        public Solver(KnapsackProbrem kp)
        {
            this.kp = kp;
        }
    }
}