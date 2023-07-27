using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class Interest: BankDeatials
    {
        private double  intpercent;
        public Interest(int intpercent, int accno, string accname, double balance
            , double interamt):base( accno,accname,balance,interamt) {
        

            this.Intpercent = intpercent;
        }

        public double Intpercent { get => intpercent; set => intpercent = value; }

        public override  double CaluculateInterest()
        { return Balance*1*(intpercent/100); }
    }
}
