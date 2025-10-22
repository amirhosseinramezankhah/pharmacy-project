using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data;
namespace BLL
{
    public class InvoiceBLL
    {
        InvoiceDAL dal = new InvoiceDAL();
        public string Create(Invoice i, Customer c, List<Product> P)
        {
            return dal.Create(i, c, P);
        }
        public DataTable Read()
        {
            return dal.Read();
        }
        public DataTable Read(string s)
        {
            return dal.Read(s);
        }
        //public DataTable ReadN(string s)
        //{
        //    return dal.ReadN(s);
        //}
        public string ReadInvoiceNum()
        {
            return dal.ReadInvoiceNum();
        }
        public Invoice ReadById(int id)
        {
            return dal.ReadById(id);
        }
        public Invoice ReadFullInvoice(int invoiceID)
        {
            return dal.ReadFullInvoice(invoiceID);
        }
        public string Update(Invoice i, int id , List<Product> products)
        {
            return dal.Update(i, id , products);
        }
        public string Delete(int id)
        {
            return dal.Delete(id);
        }
        public string Done(int id)
        {
            return dal.Done(id);
        }
        public int UpdateInvoiceCount()
        {
            return dal.UpdateInvoiceCount();    
        }

    }
}
