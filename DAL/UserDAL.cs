using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class UserDAL
    {
         DB db = new DB();

        public string Create(User u,UserGroup ug)
        {
            try
            {
                if (Read(u))
                {
                    u.UserGroup = db.userGroups.Find(ug.id);
                    db.users.Add(u);
                    db.SaveChanges();
                    return "ثبت اطلاعات با موفقیت انجام شد";
                }
                else
                {
                    return "نام کاربری وارد شده تکراری است";
                }

            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی مواجه شد:\n" + e.Message;
            }
           
        }
        public bool IsRegistered()
        {
            return db.users.Count() > 0;
        }

        public bool Read(User u)
        {
            var q = db.users.Where(i=> i.UserName == u.UserName);   
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
            string cmd = "SELECT dbo.Users.Name AS [نام و نام خانوادگی], dbo.Users.UserName AS [نام کاربری], dbo.Users.RegDate AS [تاریخ ثبت], dbo.ActivityCategories.CategoryName AS [گروه کاربری], dbo.Users.id\r\nFROM dbo.Users INNER JOIN\r\n dbo.ActivityCategories ON dbo.Users.id = dbo.ActivityCategories.id";
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=Pharmacyproject11; Integrated Security=True");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
      
        public User Read(int id)
        {
            return db.users.Where(i=> i.id == id).FirstOrDefault(); 
        }
        public User ReadU(string s)
        {
            return db.users.Where(i=> i.UserName==s).SingleOrDefault(); 
        }
        public User ReadN(string Name)
        {
            return db.users.Where(u => u.UserName == Name).SingleOrDefault();
        }
        public List<string> ReadUserNames()
        {
            return db.users.Where(i => i.DeleteStatus == false).Select(i=> i.UserName).ToList();
        }
        public string Update(User u,int id)
        {
            try
            {
                var q = db.users.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.Name = u.Name;
                    q.UserName = u.UserName;    
                    q.Password = u.Password;    
                    q.Pic = u.Pic;
                    db.SaveChanges();
                    return "ویرایش اطلاعات کاربر با موفقیت انجام شد";
                }
                else
                {
                    return "کاربر مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات کاربر با مشکلی مواجه شده است\n" + e.Message;       
            }
            
        }
        public string Delete(int id)
        {
            try
            {
                User u = db.users.Where(i => i.id ==id).FirstOrDefault();   
                u.DeleteStatus = true;
                db.SaveChanges();
                return "کاربر مورد نظر حذف شد";
            }
            catch (Exception e)
            {
                return "حذف کاربر با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
           
            
        }
        public User Login(string u, string p)
        {
            
            return db.users.Include("UserGroup").Where(i => i.UserName == u && i.Password == p).SingleOrDefault();
        }
        public bool Access(User u, string s, int a)
        {
            UserGroup ug = db.userGroups.Include("userAccessRoles").Where(i => i.id == u.UserGroup.id).FirstOrDefault();
            UserAccessRole uar = ug.userAccessRoles.Where(z => z.Section == s).FirstOrDefault();
            if (a == 1)
            {
                return uar.CanEnter;
            }
            else if (a == 2)
            {
                return uar.CanAddInformation;
            }
            else if (a == 3)
            {
                return uar.CanUpdate;
            }
            else
            {
                return uar.CanDelete;
            }
        }
        public List<User> ReadInvoicesList()
        {
            return db.users.Include("Invoices").Where(i => i.DeleteStatus == false).ToList();
        }
        public List<User> ReadActivity()
        {
            return db.users.Include("Activities").Where(i=> i.DeleteStatus == false).ToList();
        }
    }
}
