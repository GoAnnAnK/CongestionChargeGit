using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CongestionChargeGit.Contracts.Enums;


namespace CongestionChargeGit.Persistence.Models
{
    public class Bill
    {
        public Guid Id { get; set; }
        public AutoType AutoType { get; set; }
        public TimeSpan AllTime { get; set; }
        public decimal Fee { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}; \n Your auto Type: {AutoType}; \n Your spent time {AllTime}; \n Your amount to pay: {Fee}   ";
        }
        static void PrintBill(List<Transport> transportList)
        {
            foreach (var transport in transportList)
            {

                Console.WriteLine("Bill: ");
            }
        }
        internal void Example()
        {
            throw new NotImplementedException();
        }



    }
}
