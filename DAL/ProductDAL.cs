using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class ProductDAL
    {
        DB db = new DB();

        public string Create(Product p)
        {
            try
            {
                db.Products.Add(p);
                db.SaveChanges();
                return "ثبت اطلاعات محصول با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت اطلاعات با مشکلی مواجه شد:\n" + e.Message;

            }
        }
        public bool Exist(Product p)
        {
            return db.Products.Any(i => i.Name == p.Name);
        }

        public DataTable Read()
        {
            string cmd = "SELECT id, Name AS [نام محصول], Price AS [قیمت محصول], Stock AS تعداد, RegDate AS [تاریخ ثبت]\r\nFROM dbo.Products\r\nWHERE (DeleteStatus = 0)";
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
            SqlCommand cmd = new SqlCommand("dbo.SearchProduct");
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
        public Product Read(int id)
        {
            return db.Products.Where(i => i.id == id).FirstOrDefault();
        }
        public string Update(Product p, int id)
        {
            try
            {
                var q = db.Products.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.Name = p.Name;
                    q.Price = p.Price;
                    q.Stock = p.Stock;
                    db.SaveChanges();
                    return " ویرایش اطلاعات  محصول با موفقیت انجام شد";
                }
                else
                {
                    return "محصول مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات محصول با مشکلی مواجه شد:\n" + e.Message;
            }

        }
        public string Delete(int id)
        {
            Product p = Read(id);
            db.Products.Remove(p);
            p.DeleteStatus = true;
            db.SaveChanges();
            return "محصول مورد نظر حذف شد";
        }
        public List<string> ReadByName()
        {
            return db.Products.Where(i => i.DeleteStatus == false).Select(i => i.Name).ToList();    
        }
        public Product ReadByNameList(string product)
        {
            return db.Products.Where(i => i.Name == product).SingleOrDefault();
        }
        public string ProductsCount()
        {
            return db.Products.Count().ToString();
        }
        public int UpdateProductCount()
        {
            return db.Products.Count();
        }
    }
}
