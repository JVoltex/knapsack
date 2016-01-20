using System;

namespace Knapsack
{
    internal class DP : KPSolver
    {
        private int[,] res;
        public DP(KnapsackProbrem kp) : base(kp)
        {
            res = new int[kp.shinaList.Length + 1, kp.maxWeight + 1];
            res_value = solve(0, kp.maxWeight);
        }

        private void res_set()
        {
            for(int j = 0; j < res.GetLength(1); j++)
            {
                res[res.GetLength(0) - 1, j] = 0;
            }
        }
        private int solve(int shinaId, int weightSlack)
        {
            res_set();
            for (int i = kp.shinaList.Length - 1; i >= 0; i--)
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    if (kp.shinaList[i].Weight > j) res[i, j] = res[i + 1, j];
                    else res[i, j] = Math.Max(
                        res[i + 1, j], 
                        res[i + 1, j - kp.shinaList[i].Weight] + kp.shinaList[i].Value);
                }
            return res[shinaId, weightSlack];
        }
    }
}