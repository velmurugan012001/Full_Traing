
using DB;
using System.Text;
using System.Configuration;
class program : ConfigurationSection
{
    private static object cnnstr;

    public static void Main(string[] args)
    {
       // DIsconnect dIsconnect = new DIsconnect();
       // dIsconnect.OpenConn();



      /* Console.WriteLine( ConfigurationManager.AppSettings["n1"]);

        Console.WriteLine(ConfigurationManager.AppSettings["n2"]);
        */
/*
StringBuilder cnnstr = new StringBuilder("data Source=");
Console.WriteLine("Enter Data source");
cnnstr.Append(Console.ReadLine());
cnnstr.Append(";Initial Catalog =");
Console.WriteLine("Enter DataBase name");
cnnstr.Append(Console.ReadLine());
cnnstr.Append(";Integrated Security= SSPI");
Console.WriteLine(cnnstr);

*/


DBS db = new DBS();

db.OpenConn(cnnstr);
//db.CreateTable();
 db.insertTable();
// db.updateTable();
//db.ReadTable();
//db.CloseConn();
}
}









