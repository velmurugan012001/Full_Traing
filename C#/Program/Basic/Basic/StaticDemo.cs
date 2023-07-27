using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class StaticDemo
    {
        static int cno =123, pre=1000, curr=11000;
        static double amt;

        public static int Cno { get => cno; set => cno = value; }
        public static int Pre { get => pre; set => pre = value; }
        public static int Curr { get => curr; set => curr = value; }
        public static double Amt { get => amt; set => amt = value; }



        static StaticDemo() { 
        if ((curr - pre)<=100)
                Amt= 0;
        }
        public static void calc()
        {
            int usage = (curr - pre);
            if (usage > 100 && usage <= 200) 
            amt = usage * 2;
            else
                amt = usage *4 ;

        }
        public void disp()
        {
            Console.WriteLine(amt + "yours");
        }

    }
}
