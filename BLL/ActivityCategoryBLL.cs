using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ActivityCategoryBLL
    {
        ActivityCategoryDAL dal = new ActivityCategoryDAL();
        public string Create(ActivityCategory a)
        {
            return dal.Create(a);
        }
        public DataTable Read()
        {
            return dal.Read();
        }
        public ActivityCategory ReadById(int id)
        {
            return dal.Read(id);
        }
        public string Delete(int id)
        {
            return dal.Delete(id);
        }
        public string Update(ActivityCategory activity, int id)
        {
            return dal.Update(activity, id);
        }
        public List<string> ActivityCategoryReadUserNamesList()
        {
            return dal.ActivityCategoryReadUserNamesList();
        }
        public ActivityCategory ReadByName(string Name)
        {
            return dal.ReadByName(Name);
        }
    }
}
