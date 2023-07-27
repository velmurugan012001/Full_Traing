using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Basic
{
    public class BankTransaction
    {
        private int custid;
        private long accno;
        private decimal balance, creditamt, debitamt;
        private string accname, status;

        public BankTransaction(int custid , long accno, string accname, decimal balance)
        { 
           this.Custid= custid;this. accno=accno;this. balance= balance; creditamt= 0; debitamt= 0;
           this. accname = accname;
            status = "InActive";
        }

        public int Custid { get => custid; set => custid = value; }
        public decimal Creditamt { get => creditamt; set => creditamt = value; }
        public string Status { get => status; set => status = value; }
        public long Accno { get => accno; set => accno = value; }
        public string Accname { get => accname; set => accname = value; }

        internal decimal PerformTransations()  
        {
            Console.WriteLine("1.Credit 2. Debit");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Credit amt");
                   this .Creditamt= Convert.ToDecimal(Console.ReadLine());
                   this. Balance += this.creditamt;
                   this. Status = "Action";
                    break;

                case 2:
                    Console.WriteLine("Enter debit amt");
                   this. debitamt = Convert.ToDecimal(Console.ReadLine());
                   this. balance -= this.debitamt;
                    status = "Action";
                    break;
                    default:
                    Console.WriteLine("Enter 1 or 2 only");
                    break;
            }
            return this. balance;
        }
        
    }
}*/ 
