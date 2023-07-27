using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class VoteCheck
    {
            public static List<People>where (People[]peoples,EligibilityCheck del)
        {
            List<People> voters = new List<People>();
            foreach(People person in peoples)
            {
                if (del(person)) 
                {
                    voters.Add (person);
                }

            }
            return voters;

        }

        public void filterOfType()
        {
            IList element = new ArrayList();
            element.Add(1);
            element.Add("Two");
            element.Add(3);
            element.Add(4);
            element.Add("five");

            var strings = from e in element.OfType<string>() select e;
            var numbers = from e in element.OfType<int>() select e;

            foreach(string str in strings)
                Console.WriteLine("string " +str);
            foreach (int num in numbers)
                Console.WriteLine("nuber" +num);
        }
        public void students()
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "Vel", Age = 22 },
            new Student() { StudentID = 1, StudentName = "siva", Age = 21 },

            new Student() { StudentID = 1, StudentName = "yfv", Age = 35 },

            new Student() { StudentID = 1, StudentName = "thr", Age = 53 }
        };

           // var result = StudentList.ToLookup(students=>s.StudentName);
        }
    }
}
