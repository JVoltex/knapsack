using System.Collections.Generic;

namespace Knapsack
{
    internal class KPSolver
    {
        protected readonly KnapsackProbrem kp;
        protected int res_value;

        public KPSolver(KnapsackProbrem kp)
        {
            this.kp = kp;
        }

        private int solve(int shinaId, int weightSlack)
        {
            return 0;
        }

        public int Res_value
        {
            get
            {
                return res_value;
            }

            set
            {
                res_value = value;
            }
        }
    }
}