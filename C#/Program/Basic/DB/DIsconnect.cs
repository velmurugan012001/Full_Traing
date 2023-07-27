using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    internal class DIsconnect
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public void OpenConn()
        {
            //ConfigurationManager.RefreshSection("connectionStrings");

            string cnnstr = "data source=DESKTOP-BQF0PSQ\\SQLEXPRESS; Initial catalog=student; integrated security=SSPI";
            Console.WriteLine(cnnstr);
            conn = new SqlConnection(cnnstr);
            try
            {
                conn.Open();
                Console.WriteLine("Opened");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connection not established");
            }
        }
        public void ReadData()
        {
            da = new SqlDataAdapter("select * from stud_details", conn);
            conn.Close();

            ds = new DataSet();
            da.Fill(ds, "sd");
            //  Console.WriteLine(ds.Tables["sd"].Columns[0].Unique);
            //  Console.WriteLine(ds.Tables["sd"].Columns[1].ColumnName);

            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                Console.WriteLine(dr["name"].ToString() + dr["rno"]);
            }
        }
        public void InsertRecord(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            ds.Tables["sd"].Columns["rno"].Unique = true;
            ds.Tables["sd"].Columns["name"].DefaultValue = "XXX";


            DataRow dr = ds.Tables["sd"].NewRow();

            dr[0] = rno;

            ds.Tables["sd"].Rows.Add(dr);

            da.Update(ds, "sd");
            Console.WriteLine("Inserted");
            conn.Close();
        }

        public void UpdateRecord(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                if (Int32.Parse(dr["rno"].ToString()) == rno)
                {
                    dr["name"] = "FFF";
                    break;
                }
            }

            Console.WriteLine("Updated");
            da.Update(ds, "sd");
            Console.WriteLine("Updated");
            conn.Close();
            //  ReadData();
        }

        public void DeleteRecord(int rno)
        {
            SqlCommandBuilder scb = new SqlCommandBuilder(da);

            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                if (Int32.Parse(dr["rno"].ToString()) == rno)
                {
                    dr.Delete();
                    break;
                }
            }

            da.Update(ds, "sd");
            Console.WriteLine("Deleted");
            conn.Close();
        }

    }
}
