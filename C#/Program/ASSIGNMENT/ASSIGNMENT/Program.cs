/* Author: Velmurugan
 * Date: 25 / 03 / 2023
 * Description:Assigment
 */

using ASSIGNMENT;

/*namespace Basic
{

    class Program
    {
        public static void Main(string[] args)
        {
            // Assignment assigment = new Assignment();
            /* int X, Y;
             Console.WriteLine("The valu for X coordinate :");
             X = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("The value for Y coodinate :");
             Y = Convert.ToInt32(Console.ReadLine());
             assigment.coordinate(X, Y);*/
/*  int Rollno, phy, chm, ca;
  string std;
  Console.WriteLine("Input the Roll Number of the student :");
  Rollno=Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Input the Name of the Student :");
  std=Console.ReadLine();    
  Console.WriteLine("Input the marks of Physics, Chemistry and Computer Application : ");
  phy=Convert.ToInt32(Console.ReadLine());
  chm=Convert.ToInt32(Console.ReadLine());
  ca=Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Roll No :" + Rollno);

  Console.WriteLine("Name of Student :" + std);
  Console.WriteLine("Marks in Physics :" + phy);
  Console.WriteLine("Marks in Chemistry :" + chm);
  Console.WriteLine("Marks in Computer Application :" + ca);
  assigment.marks(phy,chm,ca);*/

/* int cutid, unit;
 string name;
 Console.WriteLine("customer id:");
 cutid=Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Name");
 name=Console.ReadLine();
 Console.WriteLine("unit consumed");
 unit=Convert.ToInt32(Console.ReadLine());
 assigment.EB(unit,cutid,name);*/


// inheritance multi lavel 
/*  Console.WriteLine("Enter Roll Number");
   int Rno = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Enter Name of the Student");
   string name = Console.ReadLine();
   Console.WriteLine("Enter Physics Mark of the Student");
   double mark1 = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Enter Chemics Mark of the Student");
   double mark2 = Convert.ToDouble(Console.ReadLine());
   Console.WriteLine("Enter Computer Application Mark of the Student");
   double mark3 = Convert.ToDouble(Console.ReadLine());

   StudentCalculation studentCalculation = new StudentCalculation(Rno, name , mark1, mark2, mark3,0.0,0.0);
   studentCalculation.Calculate();
   Console.WriteLine($"Roll number : {studentCalculation.Rno}\n Name :" +
   $" {studentCalculation.Name}\n Total : {studentCalculation.Tot}\n Average : {studentCalculation.Avg}");*

  /*
  Console.WriteLine("Enter college," + "addr,pin");
  string collegename=Console.ReadLine();
  string address=Console.ReadLine();
  int pin = Convert.ToInt32(Console.ReadLine());  

  Console.WriteLine("EID,name,dep,favsub," + "sal Ts");
  int eid = Convert.ToInt32(Console.ReadLine());
  string name=Console.ReadLine();
  string dep=Console.ReadLine();
  string favsub=Console.ReadLine();
  double sal=Convert.ToDouble(Console.ReadLine());
  Console.WriteLine("EID,name,sal");
  int aeid=Convert.ToInt32(Console.ReadLine());
  string aname=Convert.ToString(Console.ReadLine());  
  double asal=Convert.ToDouble(Console.ReadLine());


  TeachingStaff teachingStaff = new TeachingStaff(collegename, address, pin, eid,
name, dep, favsub, sal);
  AdminStaff adminStaff = new(
       eid, name, sal, collegename, address, pin);

  double tsal = teachingStaff.Calculatesalary();
  double asal = teachingStaff.Calculatesalary();


  Console.WriteLine("College Name" +
  teachingStaff.Collegename + "TS Emp name" + teachingStaff, name + "TS Salary" + tsal +"")*/


/* int rows;
  Console.Write("Input number of rows : ");
  rows = Convert.ToInt32(Console.ReadLine());
  assigment.rowno(rows);*/




/* string str;
  int i = 0, wrd = 0, l = 0;
  Console.Write("Input the string : ");
  str = Console.ReadLine();
  assigment.Alph(str, i, wrd, l);*/


/*   int i = 0, n = 0;
   Console.Write("Input the number of elements to store in the array :");
   n = Convert.ToInt32(Console.ReadLine());
   assigment.Array(i, n);*/

/*   int npalindrom;
   string spalindrom;
   Console.WriteLine("Enter a number to check a palindrom or not:");
   npalindrom = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Enter a String to check a palindrom or not:");
   spalindrom = Console.ReadLine();
   Palindrom palindrom = new Palindrom();

   palindrom.StringPalindrom(spalindrom);
   palindrom.NumberPalindrom(npalindrom);*/
/* Addition addition= new Addition();
 int n3=10 , n4 =20 ;
 addition.add(n3, n4, out int n1, out int n2);
 Console.WriteLine(n1 +"  "+n2); */



/* Interest interest = new Interest(20, 1010101, "AAA", 20000, 0);
 double interamt = interest.CaluculateInterest();
 Console.WriteLine(interamt);*/



/* Sample sample= new Sample();
 Console.WriteLine( sample.intadd(1, 2));
 Console.WriteLine(  sample.stradd("v","l"));*/



/* Animal dog=new Animal("dog",2,1,4,1);
 Animal cow=new Animal("cow",2,1,4,1);
 Animal cat=new Animal("cat",2,1,4,1);


 cat.MakeSound(cat.Name);
 cow.Type(cat.Name);*/
/*
            BankAccount bankaccout = new BankAccount(1234,3242234,"AAA",10000,"inactive");

            Console.WriteLine("1.Custid 2. AccNo");
            int ch = Convert.ToInt32(Console.ReadLine());   
            switch(ch)
            {
                case 1:
                    bankaccout.Checkaccstatus(1234);
                    Console.WriteLine(bankaccout.Accno + bankaccout.Name + bankaccout.Balance + bankaccout.Status); 
                    break;
                    case 2:
                    bankaccout.Checkaccstatus(3242234); 
                    Console.WriteLine(bankaccout.Custid + bankaccout.Name + bankaccout.Balance + bankaccout.Status);
                    break;
                default:
                    Console.WriteLine("enter1 or 2");
                    break;

            }
           
            BankAccount bk = new BankAccount();
            bk = bankaccout;
            Console.WriteLine("Copied data"+bk.Name);
      




           
        }

    }
   
    
}       */


/* Author: Velmurugan
 * Date: 04 / 04 / 2023
 * Description:Assigment
 */

namespace Basic
{

    class Program
    {
        public static void Main(string[] args)
        {
            /* Console.WriteLine("Enter the chicken count");
             int chicken = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the cow count");
             int cow = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the pig count");
             int pig = Convert.ToInt32(Console.ReadLine());
             Farmer farmer = new Farmer(chicken, cow, pig);
             Console.WriteLine(farmer.count_legs());*/

            /* Console.WriteLine("Enter the number of wins");
             int wins = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the number of draws");
             int draws = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter the losses");
             int losses = Convert.ToInt32(Console.ReadLine());
             Football football = new Football();
             Console.WriteLine(football.FootballPoints(wins, draws, losses));*/


            Console.WriteLine("Enter the prob");
            double prob = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the prize");
            int prize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the pay");
            int pay = Convert.ToInt32(Console.ReadLine());

            Gamble gamble = new Gamble();
            Console.WriteLine(gamble.ProfitableGamble(prob, prize, pay));
        }
    }
}






