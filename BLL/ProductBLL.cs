using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class ProductBLL
    {
        ProductDAL dal = new ProductDAL();
        public string Create(Product p)
        {
            if (dal.Exist(p) == false)
            {
                return dal.Create(p);
            }
            return "محصول تکراری است";
        }
        public DataTable Read()
        {
            return dal.Read();
        }
        public Product Read(int id)
        {
            return dal.Read(id);
        }
        public DataTable Read(string s)
        {
            return dal.Read(s);
        }
        public string Update(Product p, int id)
        {
            return dal.Update(p, id);
        }
        public string Delete(int id)
        {
            return dal.Delete(id);
        }
        public List<string> ReadByName()
        {
            return dal.ReadByName();
        }
        public Product ReadByNameList(string product)
        {
            return dal.ReadByNameList(product);
        }
        public string ProductsCount()
        {
            return dal.ProductsCount();
        }
        public int UpdateProductCount()
        {
            return dal.UpdateProductCount();    
        }
    }
}

