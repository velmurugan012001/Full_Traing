/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT
{
    internal class AdminStaff : College
    {
        int eid;
        string name;
        double salary;


        public AdminStaff(int eid, string name, double salary, string collegename, string adders, int pin) :
            base(collegename, adders, pin);
       public int Eid { get => eid; set => eid = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

        public double Calculatesalary()
        {
            double da = 0.3; double hra = 0.15;
            double allowances = (salary * da) + (salary * hra);
            double pf = 0.12;
            double deducation = salary * pf;
            double netsal = salary + allowances - deducation;
            return netsal;
        }
    }
}
*/