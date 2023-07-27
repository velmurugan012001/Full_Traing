/* Author: Velmurugan
 * Date: 22 / 03 / 2023
 * Description:Simple Pgm1
 */



/*console.write("hello world !");
console.writeline("hello world !");

int num1, num2, ans;
console.writeline("enter 2 numbers");
num1= convert.toint32(console.readline()) ;
num2 = convert.toint32(console.readline());
ans =num1 + num2;
console.writeline("rusult :" + ans);
*/
/*double ans = Math.Sqrt(9);
Console.WriteLine(ans);
Console.WriteLine(Math.Equals(ans, ans));

string s1 = "Hi im velmurugan";
string s2 ="Hi";
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.Concat(s2));

Console.WriteLine(s1.Length);
Console.WriteLine(s1.Substring(1,6));
Console.WriteLine(s1.IndexOf('r'));
Console.WriteLine(s1 + s2);
Console.WriteLine($"{s1} @! {s2}");
Console.WriteLine($"{1} @! {2}");
int x = 8, y = 9,f = 6;/*
Console.WriteLine($"{x}+{y}+{f}");*/

/*

using Basic;
using System;
using System.Net.Security;
using System.Runtime.InteropServices;
*/
/*class Program

{
	//public static void Main(string[] args)
	{
		/*  Console.WriteLine("Enter Customer id ,accno,name,balance");
		 int custid = Convert.ToInt32(Console.ReadLine());
		 long  accno = Convert.ToInt64(Console.ReadLine());
		 string accname = Console.ReadLine();
		 decimal balance = Convert.ToDecimal(Console.ReadLine());
		  BankTransaction bankTransaction = new BankTransactio
		n(custid,accno,accname,balance);
		  */

/*int id = 1; long ano = 2466; string nm = "vel"; decimal bal = 1000;

BankTransaction bankTransaction = new BankTransaction(id, ano, nm, bal);
 bal =  bankTransaction.PerformTransations();

Console.WriteLine($"Name:{id}- Balance:{bal}- Status: Active");




// Stub stub = new Stub();
/*
string str1=Console.ReadLine();
stub.foreachfn(str1);
int max= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Total :" +sum);
int sum= stub.loopfn(max);
*/
// stub.arrdisp();
/*  Console.WriteLine("s==>2 number M==>3 number");
  string ch= Console.ReadLine();
 // char ch = Convert.ToChar(Console.ReadLine());
  switch(ch)
  {
	  case "s":
		  stub.Big2Num();
		  break;
	  case "M":
		  stub.Big3Num();
		  break;
		  default: Console.WriteLine("Enter s or M");
		  break;
  }

  stub.Big3Num();
}
}*/
/*
class Program

{
{
/*EnumDemo enumDemo= new EnumDemo();
enumDemo.Display();*/
/*Console.WriteLine("Enter the 2 num");
ExcpHandLingcs excpHandLingcs = new ExcpHandLingcs(10,5,0);

Console.WriteLine(excpHandLingcs.add());
Console.WriteLine(excpHandLingcs.mul());
Console.WriteLine(excpHandLingcs.div());

FileOperatioms fileOperatioms= new FileOperatioms();
fileOperatioms.create();


}
}
*/

using Basic;
using System;
using System.Net.Security;
using System.Runtime.InteropServices;

namespace Basic
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//FileOperatioms file = new FileOperatioms();
			//file.create();
			//file.Delete();
			//file.CopyMoveFile();
			//file.Move();
			//file.FileProperties();

			//GeneriCollectionDemo generiCollectionDemo= new GeneriCollectionDemo();
			// generiCollectionDemo.ListElement();
			//generiCollectionDemo.StackElements();
			/* NonGenericCOllectionDemo demo = new NonGenericCOllectionDemo();
			demo.ArrayListElement();
			demo.HashElements();*/


		StaticDemo sd = new StaticDemo();
			StaticDemo.calc();
			Console.WriteLine(StaticDemo.Amt);
			 .disp();

        }
	

	}
}