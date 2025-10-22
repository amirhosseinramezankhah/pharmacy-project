using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL dal = new CustomerDAL();
        public string Create(Customer c)
        {
            if (dal.Exist(c))
            {
                 return dal.Create(c);
            }
            else 
            {
                return "کاربری با همین شماره تماس در سیستم ثبت شده است";
            }          
        }
        public DataTable Read()
        {
            return dal.Read();
        }
        public DataTable Read(string s)
        {
            return dal.Read(s);
        }

        public Customer Read(int id)
        {
            return dal.Read(id);    
        }
        public string Update(Customer c,int id)
        {
            return dal.Update(c,id);
        }
        public string Delete(int id)
        {
            return dal.Delete(id);  
        }
        public List<string> ReadPhoneNumbers()
        {
            return dal.ReadPhoneNumbers();
        }
        
        public Customer ReadByPhone(string Phone)
        {
            return dal.ReadByPhone(Phone);
        }


        public Customer ReadByName(string Name)
        {
            return dal.ReadByName(Name);
        }
        public List<string> ReadCustomersName()
        {
            return dal.ReadCustomersName();
        }
        public int CustomerCount(DateTime dt1, DateTime dt2)
        {
            return dal.CustomerCount(dt1, dt2); 
        }
        public int UpdateCustomerCount()
        {
            return dal.UpdateCustomerCount();   
        }

    }
}
