using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class NonGenericCOllectionDemo
    {
        public void ArrayListElement()
        {

            ArrayList numbers = new ArrayList();
            numbers.Add(400);
            numbers.Add(20);
            numbers.Add(430);

            //for (int i = 0;i < numbers.Count; i++)
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            // numbers.Clear();
            // Console.WriteLine(numbers);
            numbers.Sort();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
        public void StackElements()
        {
            Stack numbers = new Stack ();
            numbers.Push(100);
            numbers.Push(200);
            numbers.Push(-100);
          //  Console.WriteLine(numbers.Average());
           // Console.WriteLine(numbers.Sum());

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(numbers.Pop());

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public void QueueElements()
        {
            Queue numbers = new Queue();

            numbers.Enqueue(100);
            numbers.Enqueue(200);
            numbers.Enqueue(-100);
           // Console.WriteLine(numbers.Average());
           // Console.WriteLine(numbers.Sum());

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(numbers.Dequeue());

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

          //  Console.WriteLine(numbers.First());

        }

        public void HashElements()
        {
            Hashtable students = new Hashtable();
            students.Add(1, 100);
            students.Add(2, 200);

            foreach (var key in students.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var val in students.Values)
            {
                Console.WriteLine(val);
            }

            foreach (var key in students.Keys)
            {
                Console.WriteLine(students[key]);
            }

        }

        public void SortedListElements()
        {
            SortedList students = new SortedList();
            students.Add(1, 100);
            students.Add(2, 200);

            foreach (var key in students.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var val in students.Values)
            {
                Console.WriteLine(val);
            }

            foreach (var key in students.Keys)
            {
                Console.WriteLine(students[key]);
            }
        }
    }
}
