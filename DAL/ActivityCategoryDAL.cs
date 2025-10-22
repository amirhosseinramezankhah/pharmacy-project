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
    public class ActivityCategoryDAL
    {
        DB db = new DB();
        public string Create(ActivityCategory a)
        {
            try
            {
                db.ActivityCategories.Add(a);
                db.SaveChanges();
                return "دسته بندی با موفقیت ثبت شد";
            }
            catch (Exception e)
            {
                return "ثبت  دسته بندی با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;

            }
        }
        public DataTable Read()
        {
            string cmd = "SELECT id, CategoryName AS [نام دسته بندی]\r\nFROM dbo.ActivityCategories\r\nWHERE (DeleteStatus = 0)";
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=Pharmacyproject11; Integrated Security=True");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }
        public ActivityCategory Read(int id)
        {
            return db.ActivityCategories.Find(id);
        }
        public string Update(ActivityCategory activity, int id)
        {
            try
            {
                var q = db.ActivityCategories.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.CategoryName = activity.CategoryName;
                    db.SaveChanges();
                    return "ویرایش با موفیقت انجام شد";
                }
                else
                {
                    return "دسته بندی مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "ویرایش اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }
        public string Delete(int id)
        {
            try
            {
                var q = db.ActivityCategories.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.DeleteStatus = true;
                    db.SaveChanges();
                    return "حذف با موفیقت انجام شد";
                }
                else
                {
                    return "دسته بندی مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }
        public List<string> ActivityCategoryReadUserNamesList()
        {
            return db.ActivityCategories.Where(i => i.DeleteStatus == false).Select(i => i.CategoryName).ToList();
        }
        public ActivityCategory ReadByName(string Name)
        {
            return db.ActivityCategories.Where(u => u.CategoryName == Name).SingleOrDefault();
        }
    }
}
