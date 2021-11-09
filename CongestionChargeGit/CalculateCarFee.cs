using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CongestionChargeGit.Persistence.Models;

namespace CongestionChargeGit
{
    public class CalculateCarFee : CalculateBase
    {
        public override void CalculateFee(Transport item)
        {
            var calculateTime = CalculateTime(item);
            var fee = new TimePrice
            {
                AmPrice = 2.0M,
                PmPrice = 2.5M
            };

            var feeForAm = Math.Floor((decimal)calculateTime.AmHours.TotalHours * fee.AmPrice * 10) / 10;
            var feeForPm = Math.Floor((decimal)calculateTime.PmHours.TotalHours * fee.PmPrice * 10) / 10;
            var totalFee = feeForAm + feeForPm;

            Console.WriteLine(item);
            Console.WriteLine($"Fee for {calculateTime.AmHours.Hours}h {calculateTime.AmHours.Minutes}m (AM rate): {feeForAm.ToString("C", new CultureInfo("en-GB"))}");
            Console.WriteLine($"Fee for {calculateTime.PmHours.Hours}h {calculateTime.PmHours.Minutes}m (PM rate): {feeForPm.ToString("C", new CultureInfo("en-GB"))}");
            Console.WriteLine($"Total Fee: {totalFee.ToString("C", new CultureInfo("en-GB"))}");
        }
    }
}
