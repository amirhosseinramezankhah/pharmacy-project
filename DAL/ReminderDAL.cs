using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class ReminderDAL
    {
        DB db = new DB();
        public string Create(Reminder r,User u)
        {
            try
            {
                r.Users = db.users.Find(u.id);
                db.Reminders.Add(r);
                db.SaveChanges();
                return "ثبت اطلاعات با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی روبرو شده است لطفا برسی کنید:\n" + e.Message;
            }
        }

        public DataTable Read()
        {
            string cmd = "SELECT dbo.Reminders.id, dbo.Reminders.Title AS [موضوع یادآور], dbo.Reminders.ReminderInfo AS [جزئیات یادآور], dbo.Reminders.RemindDate AS [تاریخ یادآور], dbo.Reminders.IsDone AS [انجام شده], dbo.Users.Name AS [کاربر مربوط]\r\nFROM dbo.Reminders INNER JOIN\r\n dbo.Users ON dbo.Reminders.Users_id = dbo.Users.id";
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=Pharmacyproject11; Integrated Security=True");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public Reminder Read(int id)
        {
            return db.Reminders.Find(id);
        }
        public DataTable Read(string s)
        {
            SqlCommand command = new SqlCommand("dbo.SearchReminders");
            string connectionStringText = "Data Source=.; Initial Catalog=Pharmacyproject11; Integrated Security=True";
            command.Parameters.AddWithValue("@Search",s);
            SqlConnection connection = new SqlConnection(connectionStringText);
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            var sqldataadpter = new SqlDataAdapter();
            sqldataadpter.SelectCommand = command;
            var dataset = new DataSet();
            sqldataadpter.Fill(dataset);
            return dataset.Tables[0];
        }
       

        public string Update(Reminder r, int id)
        {
            var q =db.Reminders.Where(i=> i.id == id).SingleOrDefault();    
            try
            {
                if (q != null)
                {
                    q.RemindDate = r.RemindDate;
                    q.ReminderInfo = r.ReminderInfo;
                    q.Title = r.Title;
                    db.SaveChanges();
                    return "ویرایش اطلاعات یادآور  با موفقیت انجام شد";
                }
                else 
                {
                    return "یادآور مورد نظر یافت نشد";
                }

            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات یادآور  با مشکلی روبرو شده است لطفا برسی کنید:\n" + e.Message;
            }
                      
        }
        public string Delete(int id)
        {
            try
            {
                var q = db.Reminders.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.DeleteStatus = true;
                    db.SaveChanges();
                    return "حذف یادآور با موفیقت انجام شد";
                }
                else
                {
                    return "یادآور مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات یادآور با مشکلی روبرو شده است لطفا برسی کنید:\n" + e.Message;
            }
        }
        public string Done(int id)
        {
            try
            {
                var q = db.Reminders.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.IsDone = true;
                    db.SaveChanges();
                    return "حذف یادآور با موفیقت انجام شد";
                }
                else
                {
                    return "یادآور مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات یادآور با مشکلی روبرو شده است لطفا برسی کنید:\n" + e.Message;
            }
        }
        public int UpdateReminderCount(int id)
        {
            return db.Reminders.Include("User").Where(i => i.Users.id == id && i.IsDone == false).Count();
        }
    }
}
