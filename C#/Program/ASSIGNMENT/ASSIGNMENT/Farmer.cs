using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class Farmer
    {
       
        private int cows;
        private int pigs;
        private int chickens;

        public Farmer(int chicken, int cow, int pig)
        {
            this.chickens = chicken;
            this.cows = cow;
            this.pigs = pig;
        }
        public int Chickens { get => chickens; set => chickens = value; }
        public int Cows { get => cows; set => cows = value; }
        public int Pigs { get => pigs; set => pigs = value; }

        public int count_legs()
        {
            int result = (this.Chickens * 2) + (this.Cows * 4) + (this.Pigs * 4);
            return result;
        }
    }
}
