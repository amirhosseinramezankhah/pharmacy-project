using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class InvoiceDAL
    {
        DB db = new DB();   
        public string Create(Invoice i,Customer c, List<Product> P)
        {
            try
            {
                i.Customer = db.Customers.Find(c.id);
                foreach (var item in P)
                {
                    i.Products.Add(db.Products.Find(item.id));
                }
                Random rnd = new Random();
                string s = rnd.Next(1000000).ToString();
                var q = db.Invoices.Where(z => z.InvoiceNumber == s);
                while(q.Count() > 0)
                {
                    s = rnd.Next(100000).ToString(); ;
                }
                i.InvoiceNumber = s;
                i.User = db.users.Find(i.User.id);
                db.Invoices.Add(i);
                db.SaveChanges();
                return "ثبت فاکتور با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "ثبت فاکتور با مشکلی مواجه شده است:\n" + e.Message;
            }
        }
        public DataTable Read()
        {
            string cmd = "SELECT dbo.Invoices.id, dbo.Customers.Name AS [نام مشتری], dbo.Customers.Phone AS [شماره تماس], dbo.Invoices.InvoiceNumber AS [شماره فاکتور], dbo.Invoices.RegDate AS [تاریخ ثبت], dbo.Invoices.IsCheckedOut AS [تسویه شده], \r\n dbo.Invoices.CheckoutDate AS [تاریخ تسویه]\r\nFROM dbo.Invoices INNER JOIN\r\n dbo.Customers ON dbo.Invoices.Customer_id = dbo.Customers.id\r\nWHERE (dbo.Invoices.DeleteStatus = 0)";
            SqlConnection con = new SqlConnection("Data Source=.; Initial Catalog=Pharmacyproject11; Integrated Security=True");
            var sqladapter = new SqlDataAdapter(cmd, con);
            var commandbuilder = new SqlCommandBuilder(sqladapter);
            var ds = new DataSet();
            sqladapter.Fill(ds);
            return ds.Tables[0];
        }

        public DataTable Read(string s)
        {
            SqlCommand command = new SqlCommand("dbo.SearchInvoice");
            string connectionStringText = "Data Source=.; Initial Catalog=Pharmacyproject11; Integrated Security=True";
            command.Parameters.AddWithValue("@Search", s);
            SqlConnection connection = new SqlConnection(connectionStringText);
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            var sqldataadpter = new SqlDataAdapter();
            sqldataadpter.SelectCommand = command;
            var dataset = new DataSet();
            sqldataadpter.Fill(dataset);
            return dataset.Tables[0];
        }

        //public DataTable ReadN(string s)
        //{
        //    SqlCommand command = new SqlCommand("dbo.SearchInvoice1");
        //    string connectionStringText = "Data Source=.; Initial Catalog=Pharmacyproject11; Integrated Security=True";
        //    command.Parameters.AddWithValue("@Search", s);
        //    SqlConnection connection = new SqlConnection(connectionStringText);
        //    command.Connection = connection;
        //    command.CommandType = CommandType.StoredProcedure;
        //    var sqldataadpter = new SqlDataAdapter();
        //    sqldataadpter.SelectCommand = command;
        //    var dataset = new DataSet();
        //    sqldataadpter.Fill(dataset);
        //    return dataset.Tables[0];
        //}
        public Invoice ReadById(int id)
        {
            return db.Invoices.Find(id);
        }
        public Invoice ReadFullInvoice(int invoiceID)
        {
            return db.Invoices.Include("Products").Include("Customer").FirstOrDefault(i => i.id == invoiceID);
        }
        public string ReadInvoiceNum()
        {
            var q = db.Invoices.OrderByDescending(i => i.id).FirstOrDefault();
            if (q == null)
            {
                return 1.ToString();
            }
            return q.InvoiceNumber;
        }
        public string Update(Invoice NewInvoice, int id , List<Product> products)
        {
            try
            {
                Invoice OldInvoice = ReadById(id);

                OldInvoice.Products.Clear();
                var q = db.Products.Include("Invoices").Where(i => i.Invoices.Contains(OldInvoice)).ToList();
                foreach(var item in q.ToList())
                {
                    item.Invoices.Remove(OldInvoice);
                }
                // افزودن محصولات جدید
                foreach (var product in products.ToList())
                {
                    product.Invoices.Add(db.Invoices.Find(OldInvoice.id));
                    OldInvoice.Products.Add(product);
                }
                OldInvoice.User = db.users.Find(NewInvoice.User.id);
                OldInvoice.Customer = db.Customers.Find(NewInvoice.Customer.id);

                db.SaveChanges();
                return "ویرایش اطلاعات فاکتور با موفیقت انجام شد";
            }
            catch (Exception e)
            {
                return "ویرایش اطلاعات فاکتور با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }
        public string Delete(int id)
        {
            try
            {
                var q = db.Invoices.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    db.Invoices.Remove(q);
                    db.SaveChanges();
                    return "حذف فاکتور با موفیقت انجام شد";
                }
                else
                {
                    return "فاکتور مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "حذف اطلاعات فاکتور با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }
        }
        public string Done(int id)
        {
            try
            {
                var q = db.Invoices.Where(i => i.id == id).FirstOrDefault();
                if (q != null)
                {
                    q.IsCheckedOut = true;
                    q.CheckoutDate = DateTime.Now;
                    db.SaveChanges();
                    return "تسویه حساب انجام شد";
                }
                else
                {
                    return "ستون مورد نظر یافت نشد";
                }
            }
            catch (Exception e)
            {

                return "تسویه حساب شخص  با مشکلی روبرو شد لطفا برسی کنید:\n" + e.Message;
            }

        }
        public int UpdateInvoiceCount()
        {
            return db.Invoices.Count();
        }
    }
}
