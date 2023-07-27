using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    internal class DBS
    {
       
        SqlConnection conn;

        public int addnum(int n1, int n2)
        {
            return n1 + n2;
        }

        public void OpenConn(string cnnstr)
        {
           // ConfigurationManager.RefreshSection("connectionStrings");
           // conn = new SqlConnection("data source=" + "DESKTOP-BQF0PSQ\\SQLEXPRESS;" + " database = student;" + " integrated security=SSPI;");
          //  conn.Open();
            Console.WriteLine(cnnstr);
            conn = new SqlConnection(cnnstr);   
            try
            {
                conn.Open();
                Console.WriteLine("DB Connected");
            }
            catch (SqlException ex) 
            { 
             Console.WriteLine("cne");
            }
        }
        public void CreateTable() { 
            SqlCommand cmd = new SqlCommand("create table stud_table(rollno INT,name nvarchar(20) )",conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Table created");

        }
        
        public void insertTable()
        {
            SqlCommand cmd = new SqlCommand(";insert into stud_table values(103,'kali')", conn);
            cmd.ExecuteNonQuery();
            Console.WriteLine("Value inserted");
        }
        public void updateTable()
        {
            SqlCommand cmd = new SqlCommand("update stud_table set name='AAA'where rollno=102" , conn);
            int cum = cmd.ExecuteNonQuery();
            Console.WriteLine(cum+"Value updata");

        }
        public void ReadTable()
        {
            SqlCommand cmd = new SqlCommand("slect * from stud_name", conn);
            SqlDataReader sdr = cmd .ExecuteReader();
            while (sdr .Read()) {
                Console.WriteLine(sdr["rno"] + "" + sdr["name"]);
            }
        }
        public void deleteTable() { 
        }
        public void ContOfStudent()
        {
            SqlCommand cmd = new SqlCommand("slect count(*) from stud_name", conn);
            object res = cmd.ExecuteNonQuery();
            if (res == null)
            {
                Console.WriteLine("No of std :"+res.ToString());
            }
        }
        public void CloseConn()
        {
            conn.Close();

        }

        internal void OpenConn(object cnnstr)
        {
            throw new NotImplementedException();
        }
    }
}
