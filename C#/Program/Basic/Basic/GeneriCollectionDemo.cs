using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class GeneriCollectionDemo
    {
        public void ListElement() { 
        
        List<int> numbers = new List<int>();
            numbers.Add(400);
            numbers.Add(20);
            numbers.Add(430);

            //for (int i = 0;i < numbers.Count; i++)
            foreach (int number in numbers){
                Console.WriteLine(number);
            }
          // numbers.Clear();
           // Console.WriteLine(numbers);
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
        public void StackElements()
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(100);
            numbers.Push(200);
            numbers.Push(-100);
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(numbers.Pop());

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public void QueueElements()
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(100);
            numbers.Enqueue(200);
            numbers.Enqueue(-100);
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Sum());

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(numbers.Dequeue());

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine(numbers.First());

        }

        public void HashElements()
        {
            Dictionary<int, int> students = new Dictionary<int, int>();
            students.Add(1, 100);
            students.Add(2, 200);

            foreach (int key in students.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (int val in students.Values)
            {
                Console.WriteLine(val);
            }

            foreach (int key in students.Keys)
            {
                Console.WriteLine(students[key]);
            }

        }

        public void SortedListElements()
        {
            SortedList<int, int> students = new SortedList<int, int>();
            students.Add(1, 100);
            students.Add(2, 200);

            foreach (int key in students.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (int val in students.Values)
            {
                Console.WriteLine(val);
            }

            foreach (int key in students.Keys)
            {
                Console.WriteLine(students[key]);
            }
        }

    }
}
