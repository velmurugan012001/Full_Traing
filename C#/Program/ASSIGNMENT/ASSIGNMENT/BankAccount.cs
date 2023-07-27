using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class BankAccount
    {
        private int custid;
        private long accno; 
        private double balance;
        private string status;
        private string name;

        public BankAccount()
        {
            this.Balance = 0;
            this.Accno = 0;
            this.Status = "";
            this.Custid= 0;
            this.Name = ""; 
            this.accno = 0;
             
        }


        public BankAccount(int custid, long accno, string name, double balance, string status)
        {
            this.accno = accno; 
            this.balance = balance;
            this.custid = custid;
          
            this.name = name;
            this.status = status;

                

        }

        public int Custid { get => custid; set => custid = value; }
        public long Accno { get => accno; set => accno = value; }
        public double Balance { get => balance; set => balance = value; }
        public string Status { get => status; set => status = value; }
        public string Name { get => name; set => name = value; }


        public void Checkaccstatus(int cusid 
           )
        {
            if (custid == Custid)
            {
                accno = Accno;
                name = Name;
                balance = Balance;
                status = Status;
            }
        }
        public void Checkaccstatus( long accno)
        {
            if (accno == Accno)
            {
                custid= Custid;
                name = Name;
                balance = Balance;
                status = Status;
            }
        }
    }

}
