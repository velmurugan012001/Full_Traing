 using GenericDelegate;


public delegate void MyDelegate(string message);
class Program
{

    //static ArithmeticException arithmeticException;
    public static void Main(string[] args)
    {

      //  MyDelegate del1 = Deligate1.method1;
        MyDelegate del2 = Deligate2.method2;


        MyDelegate del = del1 + del2;
        /*
        MyDelegate myDelegate = new MyDelegate(Deligate1.method1);
        myDelegate.Invoke("Hi");
        myDelegate = Deligate2.method2;
        myDelegate.Invoke("Hello");*/

        /*
        GenUse<ArithmeticException> ae = new GenUse<ArithmeticException>(arithmeticException);
        Console.Write(ae.disp().Message);
        */
       /* GenUse<int> intarr = new GenUse<int>(6);
       
         for (int i = 0;i<5; i++)
        {      
            intarr.setarr(i,(i+1)*10);

        }
         for (int i = 0; i<5; i++)
        {
            Console.WriteLine(intarr.getarr(i));
        }


          GenUse<char> chararr = new GenUse<char>(6);

        for (int i = 0; i<5; i++)
        {
            chararr .setarr(i,Convert.ToChar(i+65));
        }
        for (int i = 0; i < 5; i++)
        {
            Console.Write(" "+chararr.getarr(i));
        }
       */

        /* GenUse<int> guint = new GenUse<int>(10);
         GenUse<double> gudbl = new GenUse<double>(32.2346585);
         GenUse<string> gustr = new GenUse<string>("Hi Vel");


         Console.WriteLine(guint.Number);
         Console.WriteLine(gudbl.Number);
         Console.WriteLine(gustr.Number);*/

    }
}
