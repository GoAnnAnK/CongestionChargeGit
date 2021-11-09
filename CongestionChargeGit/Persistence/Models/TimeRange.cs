using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CongestionChargeGit.Persistence.Models
{
    public class TimeRange
    {
        public static TimeSpan Start7Am = TimeSpan.FromHours(7);

        public static TimeSpan Start12Pm = TimeSpan.FromHours(12);

        public static TimeSpan Start7Pm = TimeSpan.FromHours(19);
    }
}
