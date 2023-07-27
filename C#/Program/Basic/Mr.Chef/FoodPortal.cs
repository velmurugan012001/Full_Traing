using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mr_Chef

{
    internal class foodportal
    {
        SqlConnection conn;
        SqlCommand cus_details, cat_id, food_type, product, order_det, pay_type, pay, cmd2;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader s;
        private object MessageBox;

        public void OpenConn()
        {

            string cnnstr = "data source=DESKTOP-BQF0PSQ\\SQLEXPRESS; Initial Catalog = Food; Integrated Security = SSPI";

            conn = new SqlConnection(cnnstr);
            try
            {
                conn.Open();
                Console.WriteLine("DB Connected..");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Connection not established");
            }
        }

        public void createtable()
        {
            SqlCommand cus_details = new SqlCommand("create table customer_det(name varchar(10), mob_num int primary key, city varchar(10));", conn);
            SqlCommand cat_id = new SqlCommand("create table category(c_id varchar(1) primary key, c_type varchar(10));", conn);
            SqlCommand food_type = new SqlCommand("create table food_type(type_id int primary key, specification varchar(10));", conn);
            SqlCommand product = new SqlCommand("create table product(p_id int primary key,c_id varchar(1) Foreign Key references category(c_id),type_id int Foreign Key references food_type(type_id),p_name varchar(20),cost int);", conn);
            SqlCommand order_det = new SqlCommand("create table order_det(order_id int primary key, name varchar(10), mob_num int Foreign key references customer_det(mob_num),p_id int foreign key references product(p_id),quantity int, amt int);", conn);
            SqlCommand pay_type = new SqlCommand("create table payment_type(pay_id int primary key, pay_type varchar(5));", conn);
            SqlCommand pay = new SqlCommand("create table payment(payment_no int primary key, order_id int foreign key references order_det(order_id),pay_id int foreign key references payment_type(pay_id),totalamt int);", conn);

            if (conn != null)
            {
                cus_details.ExecuteNonQuery();
                cat_id.ExecuteNonQuery();
                food_type.ExecuteNonQuery();
                product.ExecuteNonQuery();
                order_det.ExecuteNonQuery();
                pay_type.ExecuteNonQuery();
                pay.ExecuteNonQuery();

                Console.WriteLine("Table Created");

            }
        }
        public void inserttable()
        {
            SqlCommand cus_details = new SqlCommand("insert into customer_det values('vel',987654,'chennai'),('murugan',982710,'chennai'),('maha',998060,'chennai'),('sri',902345,'chennai');", conn);
            SqlCommand cat_id = new SqlCommand("insert into category values('A','veg'),('B','nonveg'),('C','fastfood');", conn);
            SqlCommand food_type = new SqlCommand("insert into food_type values(1,'breakfast'),(2,'lunch'),(3,'dinner');", conn);
            SqlCommand product = new SqlCommand("insert into product values(11,'A',1,'idli',20),(12,'A',2,'meals',150),(13,'A',3,'dosa',40),(14,'B',1,'chicken sandwich',120),(15,'B',2,'chicken biriyani',150),(16,'B',3,'parotta chickencurry',140),(17,'C',1,'fried rice',120),(18,'C',2,'noodels',150),(19,'C',3,'burmi',140);", conn);

            SqlCommand order_det = new SqlCommand("insert into order_det values(100,'vel',987654,11,2,40),(101,'maha',998060,15,1,150);", conn);
            SqlCommand pay_type = new SqlCommand("insert into payment_type values(51,'cash'),(52,'NB'),(53,'UPI'),(54,'card');", conn);
            SqlCommand pay = new SqlCommand("insert into payment values(1111,100,53,40),(1112,101,54,150);", conn);
            if (conn != null)
            {
                cus_details.ExecuteNonQuery();
                cat_id.ExecuteNonQuery();
                food_type.ExecuteNonQuery();
                product.ExecuteNonQuery();
                order_det.ExecuteNonQuery();
                pay_type.ExecuteNonQuery();
                pay.ExecuteNonQuery();
                Console.WriteLine("Values Inserted");
            }

        }

        public void Cusadmin()
        {
            Console.WriteLine("Enter 1 or 2:");
            Console.WriteLine("1.Customer");
            Console.WriteLine("2.Admin");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Customer();
            }
            else if (choice == 2)
            {
                Admin();
            }
            else
            {
                Console.WriteLine("Enter vaild Number");
            }
        }
        public void Customer()
        {
            Console.WriteLine("Order your favorite food");
            Console.WriteLine("\nEnter your meal type:");
            Console.WriteLine("\nA for Veg");
            Console.WriteLine("\nB for NonVeg");
            Console.WriteLine("\nC for FastFood");
            char meal = Convert.ToChar(Console.ReadLine());
            //veg
            if (meal == 'A' || meal == 'a')
            {
                Console.WriteLine("\nPress 1 for Idli");
                Console.WriteLine("\nPress 2 for Meals");
                Console.WriteLine("\nPress 3 for Dosa");
                int mealtype = Convert.ToInt32(Console.ReadLine());
                if (mealtype == 1)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bill amount is: " + quantity * 20);
                    payment();
                }
                else if (mealtype == 2)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bill amount is: " + quantity * 150);
                    payment();
                }
                else if (mealtype == 3)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bill amount is: " + quantity * 40);
                    payment();
                }
                else
                {
                    Console.WriteLine("Enter valid number");
                }
            }
            //nonveg
            else if (meal == 'B' || meal == 'b')
            {
                Console.WriteLine("\nPress 1 for Chicken Sandwich");
                Console.WriteLine("\nPress 2 for Chicken Biriyani");
                Console.WriteLine("\nPress 3 for Parotta ChickenCurry");
                int mealtype = Convert.ToInt32(Console.ReadLine());
                if (mealtype == 1)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bill amount is: " + quantity * 120);
                    payment();
                }
                else if (mealtype == 2)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bill amount is: " + quantity * 150);
                    payment();
                }
                else if (mealtype == 3)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bill amount is: " + quantity * 140);
                    payment();
                }
                else
                {
                    Console.WriteLine("Enter valid number");
                }
            }
            //fastfood
            else if (meal == 'C' || meal == 'c')
            {
                Console.WriteLine("\nPress 1 for FriedRice");
                Console.WriteLine("\nPress 2 for Noodels");
                Console.WriteLine("\nPress 3 for Burmi");
                int mealtype = Convert.ToInt32(Console.ReadLine());
                if (mealtype == 1)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bill amount is: " + quantity * 120);
                    payment();
                }
                else if (mealtype == 2)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bill amount is: " + quantity * 150);
                    payment();
                }
                else if (mealtype == 3)
                {
                    Console.WriteLine("Enter quantity:");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your bill amount is: " + quantity * 140);
                    payment();
                }
                else
                {
                    Console.WriteLine("Enter valid number");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid character");
            }
        }
        public void payment()
        {
            Console.WriteLine("\nEnter a payment mode:");
            Console.WriteLine("\nPress 1 for cash");
            Console.WriteLine("\nPress 2 for NB");
            Console.WriteLine("\nPress 3 for UPI");
            Console.WriteLine("\nPress 4 for card");
            int pay = Convert.ToInt32(Console.ReadLine());
            if (pay == 1 || pay == 2 || pay == 3 || pay == 4)
            {
                Console.WriteLine("Payment Successfull!\nThank you for ordering!!");
            }
        }
        public void Admin()
        {
            int password = 1234;
            Console.WriteLine("Enter password:");
            int pass = Convert.ToInt32(Console.ReadLine());
            if (pass == password)
            {
                fetch();
            }
            else
            {
                Console.WriteLine("Password Incorrect");
                Console.WriteLine("Enter the correct password:");
                int pass1 = Convert.ToInt32(Console.ReadLine());
                if (pass1 == password)
                {
                    fetch();
                }
            }
        }
        public void fetch()
        {
            Console.WriteLine("Enter a number:");
            Console.WriteLine("1.View menu");
            Console.WriteLine("2.Add an item to menu");
            Console.WriteLine("3.View customer details");
            Console.WriteLine("4.Add customer details");
            for (int i = 0; i < 5; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        viewmenu();
                        break;

                    case 2:
                        Addmenuitem();
                        break;

                    case 3:
                        Viewcusdet(); break;

                    case 4:
                        Addcusdet();
                        break;
                }

            }
        }
        /*  public void Que1()
          {
              SqlCommand cmd2 = new SqlCommand("select Top 1 p_id, Sum(amt) from order_det join product on product.p_id=order_det.p_id group by p_name ;", conn);
              if (conn != null)
              {
                  SqlDataReader s = cmd2.ExecuteReader();
                  while (s.Read())
                  {

                      Console.WriteLine(s[0] + " " + s[1]);
                  }
              }
              conn.Close();

          }*/
        /*  public void Que1()
          {
              SqlCommand cmd = new SqlCommand("select name, SUM(amt) from order_det join customer_det on order_det.mob_num=customer_det.mob_num group by name;", conn);
              if (conn != null)
              {
                  SqlDataReader s = cmd.ExecuteReader();
                  while (s.Read())
                  {
                      Console.WriteLine(s[0] + " " + s[1]);
                  }
              }
              else
              {
                  Console.WriteLine("Table is empty");
              }

              conn.Close();
          }*/

        /*public void Que1()
        {
            // conn.Open();
            SqlCommand cmd3 = new SqlCommand("select name, COUNT(p_id) , SUM(amt)  FROM order_det JOIN customer_det ON order_det.mob_num = customer_det.mob_num group by name;", conn);
            if (conn != null)
            {
                SqlDataReader s = cmd3.ExecuteReader();
                while (s.Read())
                {

                    Console.WriteLine(s[0] + " " + s[1]);
                }
            }
            conn.Close();
        }

        */

        public void Viewcusdet()
        {

            da = new SqlDataAdapter("select * from customer_det", conn);
            ds = new DataSet();
            da.Fill(ds, "customer_det");
            Console.WriteLine("\nCustomer details:\n");
            foreach (DataRow dr in ds.Tables["customer_det"].Rows)
            {

                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString());
            }

        }

        public void viewmenu()
        {
            da = new SqlDataAdapter("select * from product", conn);
            ds = new DataSet();
            da.Fill(ds, "product");
            Console.WriteLine("\nMenu:\n");
            foreach (DataRow dr in ds.Tables["product"].Rows)
            {

                Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString() + " " + dr[4].ToString());
            }
        }
        /*  public void Que5()
          {
              SqlCommand cmd = new SqlCommand("update table product set cost=40 where p_name='idli';",conn);
              Console.WriteLine("Update successfull");
              da = new SqlDataAdapter("select * from product", conn);
              ds = new DataSet();
              da.Fill(ds, "product");
              Console.WriteLine("\nProduct details:\n");
              foreach (DataRow dr in ds.Tables["product"].Rows)
              {

                  Console.WriteLine(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString()+" " + dr[3].ToString()+" " + dr[4].ToString());
              }

          }*/
        public void Addcusdet()
        {
            string queryString = "INSERT INTO customer_det " +
"(name, mob_num,city) Values('john', '987604','madras')";

            SqlCommand command = new SqlCommand(queryString, conn);
            Int32 recordsAffected = command.ExecuteNonQuery();
            Console.WriteLine("Updated ");
        }

        public void Addmenuitem()
        {
            string queryString = "INSERT INTO product " +
"(p_id,c_id,type_id,p_name,cost) Values(20, 'A',1,'poori',30)";

            SqlCommand command = new SqlCommand(queryString, conn);
            Int32 recordsAffected = command.ExecuteNonQuery();
            Console.WriteLine("Updated ");
        }
    }
}