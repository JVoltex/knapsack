using System;

namespace Knapsack
{
    internal class Shina
    {
        private int weight;
        private int value;

        public int Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Shina(int weight, int value)
        {
            this.Weight = weight;
            this.Value = value;
        }
    }
}