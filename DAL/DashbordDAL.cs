using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DashbordDAL
    {
        DB db = new DB();   

        public string UserRemindersCount(User u)
        {
            User q = db.users.Include("Reminders").Where(i=> i.id==u.id).FirstOrDefault();   
            return q.Reminders.Count().ToString();  

        }
        public List<Reminder> GetUserReminders(User u)
        {
            return db.Reminders.Include("Users").Where(i=>i.Users.id==u.id).ToList();  
        }
    }
}
