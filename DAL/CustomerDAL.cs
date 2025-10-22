using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Security.Principal;

namespace DAL
{
    public class CustomerDAL
    {
        DB db = new DB();

        public string Create(Customer c)
        {
            try
            {
                db.Customers.Add(c);
                db.SaveChanges();
                return "ثبت اطلاعات مشتری با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی مواجه شد:\n" + e.Message;
               
            }
        }
        public bool Exist(Customer c)
        {
             var q = db.Customers.Where(i=> i.Phone == c.Phone);
            if (q.Count() == 0)
            {
                return true;
            }
            else 
            {
                 return false;  
            }
        }

        public DataTable Read()
        {
            string cmd = "SELECT id, Name AS [نام مشتری], Phone AS [شماره تماس], RegDate AS [تاریخ ثبت]\r\nFROM dbo.Customers\r\nWHERE (DeleteStatus = 0)";
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=Pharmacyproject11; Integrated Security=True");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public DataTable Read(string s)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=Pharmacyproject11; Integrated Security=True");
            SqlCommand cmd = new SqlCommand("dbo.SearchCustomer");
            cmd.Parameters.AddWithValue("@search", s);
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            var sqladapter = new SqlDataAdapter();
            sqladapter.SelectCommand = cmd;
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public Customer Read(int id)
        {
            return db.Customers.Where(i=> i.id == id).FirstOrDefault();
        }
        public string Update(Customer c, int id) 
        {
            try
            {
                var q = db.Customers.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.Name = c.Name;
                    q.Phone = c.Phone;
                    db.SaveChanges();
                    return " ویرایش اطلاعات با موفقیت انجام شد";
                }
                else
                {
                    return "کاربر مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات با مشکلی مواجه شد:\n" + e.Message;
            }
           
        }
        public string Delete(int id)
        {
            try
            {
                var q = db.Customers.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.DeleteStatus = true;  
                    db.SaveChanges();
                    return " حذف مشتری با موفقیت انجام شد";
                }
                else
                {
                    return "کاربر مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {
                return "حذف اطلاعات مشتری با مشکلی مواجه شد:\n" + e.Message;
            }
        }
        public List<string> ReadPhoneNumbers()
        {
            return db.Customers.Where(x => x.DeleteStatus == false).Select(i => i.Phone).ToList();
        }
        public Customer ReadByName(string Name)
        {
            return db.Customers.Where( u=> u.Name == Name).FirstOrDefault();  
        }
        public Customer ReadByPhone(string phone)
        {
            return db.Customers.Where(u => u.Phone == phone).FirstOrDefault();
        }


        public List<string> ReadCustomersName()
        {
            return db.Customers.Select(i => i.Name ) .ToList();
        }
        public int CustomerCount(DateTime dt1, DateTime dt2)
        {
            return db.Customers.Count();   
        }
        public int UpdateCustomerCount()
        {
            return db.Customers.Count();
        }


    }
}
