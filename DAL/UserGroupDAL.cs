using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class UserGroupDAL
    {
        DB db = new DB();
        public string Create(UserGroup ug)
        {
            try
            {
                db.userGroups.Add(ug);
                db.SaveChanges();
                return "ثبت گروه کاربری با موفقیت انجام شد";
            }
            catch (Exception e)
            {
                return "در ثبت گروه کاربری مشکلی به وجود آمده است" + e.Message;
            }
        }
        public bool ReadByTitle(string Title)
        {
            return !db.userGroups.Any(x => x.Title == Title);
        }
        public List<string> ListReadUGTitle()
        {
            return db.userGroups.Select(x => x.Title).ToList();
        }
        public UserGroup ReadBySingelTitle(string title)
        {
            return db.userGroups.Where(x => x.Title == title).FirstOrDefault();
        }

    }
}
