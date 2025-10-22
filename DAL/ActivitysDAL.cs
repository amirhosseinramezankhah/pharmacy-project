using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ActivitysDAL
    {
        DB db = new DB();   
        public string Create(Activity a, User u, Customer c, ActivityCategory ac)
        {
            try
            {
                a.User = db.users.Find(u.id);
                a.Customer = db.Customers.Find(c.id);
                a.Category = db.ActivityCategories.Find(ac.id);
                db.Activitys.Add(a);
                db.SaveChanges();
                return "ثبت فعالیت با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت فعالیت با مشکلی مواجه شد" + e.Message;
            }
        }
        public DataTable Read()
        {
            string cmd = "SELECT dbo.Activities.id, dbo.Customers.Name AS [نام مشتری], dbo.Users.UserName AS [نام کاربر], dbo.ActivityCategories.CategoryName AS [دسته بندی], dbo.Activities.Title AS [موضوع فعالیت], dbo.Activities.RegDate AS [تاریخ ثبت]\r\nFROM dbo.Activities INNER JOIN\r\n dbo.ActivityCategories ON dbo.Activities.Category_id = dbo.ActivityCategories.id INNER JOIN\r\n dbo.Customers ON dbo.Activities.Customer_id = dbo.Customers.id INNER JOIN\r\n dbo.Users ON dbo.Activities.User_id = dbo.Users.id\r\nWHERE (dbo.Activities.DeleteStatus = 0)\r\nGROUP BY dbo.Activities.id, dbo.Activities.Title, dbo.ActivityCategories.CategoryName, dbo.Activities.RegDate, dbo.Customers.Name, dbo.Users.UserName";
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
            SqlCommand cmd = new SqlCommand("dbo.SearchActivity");
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
        public Activity Read(int id)
        {
            return db.Activitys.Where(i => i.id == id).FirstOrDefault();
        }
        public string Delete(int id)
        {
            try
            {
                var q = db.Activitys.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.DeleteStatus = true;
                    db.Activitys.Remove(q);
                    db.SaveChanges();
                    return "حذف با موفیقت انجام شد";
                }
                else
                {
                    return "یادآور مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }
       
        public string ReadByInfo(int id)
        {
            return db.Activitys.FirstOrDefault(i => i.id == id).Info;
        }
        public int UpdateActivitysCount()
        {
            return db.Activitys.Count();
        }
    }
    
}
