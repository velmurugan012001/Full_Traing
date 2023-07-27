using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQtoSQL
{
    internal class sudentDetail
    {
        DataClasses1DataContext data1 = new DataClasses1DataContext();


        public void ReadDataFromSql()
        {
            //var res = from st in data1.stud_tables where st.rollno > 101 select st;
            var res = data1.stud_tables.Where(st => st.rollno > 101);
            foreach (var item in res)
            {
                Console.WriteLine(item.rollno + " " + item.name);
            }
        }

        public void WriteDataToSql()
        {
            int cou = (from st in data1.stud_tables select st).Count();
            Console.WriteLine("Row :"+cou);
            int min = (int)(from st in data1.stud_tables select st.rollno).Min();

            Console.WriteLine("min :" + min);
            int max = (int)data1.stud_tables.Max(st => st.rollno);
            Console.WriteLine("max :" + max);
            double Avarge = (int)data1.stud_tables.Average(st => st.rollno);
            Console.WriteLine("Avarge :" + Avarge);

        }
        public void jion()

        {
            var result = data1.emps.Join(data1.depts,
                e => e.deptno, d => d.deptnum, (e, d) => new
            {
                xxx = e.ename,
                yyy = d.dname
            });
            foreach ( var r in result) 
            {
                Console.WriteLine(r.xxx + "" + r.yyy );
            }
        }
    }
}
