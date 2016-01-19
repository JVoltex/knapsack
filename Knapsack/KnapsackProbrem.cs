using System;
using System.Collections.Generic;
namespace Knapsack
{
    internal class KnapsackProbrem
    {
        public Shina[] shinaList;
        public int maxWeight;

        public KnapsackProbrem(Shina[] shinaList, int maxWeight)
        {
            this.shinaList = shinaList;
            this.maxWeight = maxWeight;
        }

        public static KnapsackProbrem MakeProblem(int maxWeight, int shinaMaxWeight, int shinaMaxValue, int shinaNum)
        {
            Random r = new Random();
            Shina[] shinaList = new Shina[shinaNum];
            KnapsackProbrem ret;
            for (int i = 0; i < shinaNum; i++)
            {
                Shina s  = new Shina ( r.Next() % shinaMaxWeight, r.Next() % shinaMaxValue);
                shinaList[i] = s;
            }
            ret = new KnapsackProbrem(shinaList, maxWeight);
            return ret;
        }
    }
}