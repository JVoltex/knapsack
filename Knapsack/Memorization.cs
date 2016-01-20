using System;

namespace Knapsack
{
    internal class Memorization : KPSolver
    {
        private int[,] mem;
        public Memorization(KnapsackProbrem kp) : base(kp)
        {
            mem = new int[kp.shinaList.Length, kp.maxWeight + 1];
            init_mem();
            res_value = solve(0, kp.maxWeight);
        }

        private void init_mem()
        {
            for (int i = 0; i < mem.GetLength(0); i++)
                for (int j = 0; j < mem.GetLength(1); j++)
                    mem[i, j] = -1;
        }

        private int solve(int shinaId, int weightSlack)
        {
            if (shinaId.Equals(kp.shinaList.Length))
            {
                return 0;
            }
            else if (!mem[shinaId, weightSlack].Equals(-1))
            {
                return mem[shinaId, weightSlack];
            }
            Shina s = kp.shinaList[shinaId];
            if (s.Weight > weightSlack)
            {
                int r = solve(shinaId + 1, weightSlack);
                mem[shinaId, weightSlack] = r;
                return r;
            }
            else
            {
                int r = Math.Max(
                    solve(shinaId + 1, weightSlack), 
                    solve(shinaId + 1, weightSlack - s.Weight) + s.Value);
                mem[shinaId, weightSlack] = r;
                return r;
            }
        }
    }
}