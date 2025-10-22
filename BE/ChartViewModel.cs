using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ChartViewModel
    {
        public string name { get; set; }
        public Int64 count { get; set; }
        public static List<ChartViewModel> GetChartDataForUserActivities(List<User> Users, DateTime datestart, DateTime dateend)
        {
            List<ChartViewModel> result = new List<ChartViewModel>();
            foreach (var user in Users)
            {
                result.Add(new ChartViewModel()
                {
                    name = user.UserName,
                    count = user.Activities.Count(i => i.RegDate.Date >= datestart && i.RegDate.Date <= dateend)
                });
            }
            return result;
        }
    }
}
