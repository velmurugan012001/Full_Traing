/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class TeachingStaff
    {
        private int eid;
        private string name , dep,favsub;
        private double sal;

        public TeachingStaff(string collegename, string adders, int pin, int eid,
            string name, string dep, string favsub, double sal) : base(collegename, adders, pin)
        {
            this.Eid = eid;
            this.Name = name;
            this.dep = dep;
            this.Favsub = favsub;
            this.Sal = sal;
        }

        public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public string Addr { get => dep; set => dep = value; }
        public string Favsub { get => favsub; set => favsub = value; }
        public double Sal { get => sal; set => sal = value; }

        public double Calculatesalary() 
        {
            double da = 0.4;double hra = 0.2;
            double allowances = (sal * da) + (sal * hra);
            double pf = 0.25;
            double deducation = sal * pf;
            double netsal = sal + allowances - deducation;
            return netsal;
             }
    }
}
*/