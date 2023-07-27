using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Stub
{
    /* public void Big2Num()
     {
         int num1, num2;
         Console.WriteLine("Enter 2 Number");
         num1 = Convert.ToInt32(Console.ReadLine());
         num2 = Convert.ToInt32(Console.ReadLine());
         if (num1 == num2)
             Console.WriteLine("Both are equal");
         else if (num1 > num2)
             Console.WriteLine(num1 + "Num1 is grater then num2");
         else
             Console.WriteLine(num2 + "Num1 is lesser then num2");
     }




     public void Big3Num()
     {
         int num1, num2, num3;
         Console.WriteLine("Enter 3 Number");
         num1 = Convert.ToInt32(Console.ReadLine());
         num2 = Convert.ToInt32(Console.ReadLine());
         num3 = Convert.ToInt32(Console.ReadLine());
         if ((num1 == num2) && (num2 == num3))
             Console.WriteLine("All are equal");
         else if ((num1 > num2) && (num2 > num3))
             Console.WriteLine(num1 + "Num1 is grater then num2");
         else if ((num1 < num2) && (num2 < num3))
             Console.WriteLine(num2 + "Num1 is grater then num2");
         else
             Console.WriteLine(num3 + "Num1 is grater then num2");
     }*/
  /*  public void loopfn(int max)

    {
       /* int max,cou=1, sum=0;
        max = Convert.ToInt32( Console.ReadLine());
        do
        {
            sum = sum + cou;
            cou++;
        }
        while (cou <= max);
        Console.WriteLine("Total :"+sum);*/

// while

      /*  int max, cou = 1, sum = 0;
        max = Convert.ToInt32(Console.ReadLine());
        while (cou <= max)
        {
            sum = sum + cou;
            cou++;
        }
        
        Console.WriteLine("Total :" + sum);*/
        // for
     /*   int sum = 0;
      
        
        for(int cou =2 ; cou <= max; cou++)
        {
            sum = sum + cou;

            cou++;
        }

        return sum;


    }
    public void foreachfn(string s1)
    {/*
        string s1 =Console.ReadLine();
        foreach ( char s in s1)
        {
            Console.WriteLine(s);
        }
        */
     /*   foreach (char s in s1)
        {
            Console.WriteLine(s);
        }

    }*/
    public void arrdisp()
    {
        int[] num = {90, 10, 20, 30, 40 };
        Array.Sort(num);
        foreach ( int n in num)
        {
            Console.WriteLine(n);
            
        }
    }
}