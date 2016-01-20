using System;

namespace Knapsack
{
    internal class DFS : KPSolver
    {
        public DFS(KnapsackProbrem kp) : base(kp)
        {
            res_value = solve(0, kp.maxWeight);
        }

        private int solve(int shinaId, int weightSlack)
        {
            if (shinaId.Equals(kp.shinaList.Length))
            {
                return 0;
            }
            Shina s = kp.shinaList[shinaId];
            if (s.Weight > weightSlack)
            {
                return solve(shinaId + 1, weightSlack);
            }
            else
            {
                return Math.Max(
                    solve(shinaId + 1, weightSlack), 
                    solve(shinaId + 1, weightSlack - s.Weight) + s.Value);
            }
        }
    }
}