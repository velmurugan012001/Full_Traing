using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal  class BankDeatials
    {
        private int accno;
        private string accname;
        private double balance;
        private double interamt;


       public BankDeatials(int accno,string accname,double balance,double interamt) {
        
            this.Accno = accno; 
            this.Accname = accname;
            this.Balance = balance;
            this.Interamt = interamt;

        }

        public int Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }
        public double Balance { get => balance; set => balance = value; }
        public double Interamt { get => interamt; set => interamt = value; }


       // public abstract double CaluculateInterest();


        public void BE()
        {
            List<BankDeatials> accounts = new List<BankDeatials>()
            {
                new BankDeatials(10001, "AAA", 109809, 0),
                new BankDeatials(10002, "BBB", 100000, 0)

            };
            var name = accounts.Select(x => x.Accno);
            var  bal = accounts.Select(x => x.Balance);
            foreach(var name in names)
            {
                Console.WriteLine(name);
                    
            }

        }
    }
}
