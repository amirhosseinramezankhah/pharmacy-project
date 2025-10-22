using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class UserGroupBLL
    {
        UserGroupDAL dal = new UserGroupDAL();  
        public string Create(UserGroup ug)
        {
            return dal.Create(ug);  
        }
        public bool ReadByTitle(string Title)
        {
            return dal.ReadByTitle(Title);
        }
        public List<string> ListReadUGTitle()
        {
            return dal.ListReadUGTitle();
        }
        public UserGroup ReadBySingelTitle(string title)
        {
            return dal.ReadBySingelTitle(title);
        }
    }
}
