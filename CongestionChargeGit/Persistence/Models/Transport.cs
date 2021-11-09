using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CongestionChargeGit.Contracts.Enums; 

namespace CongestionChargeGit.Persistence.Models
{
    public class Transport
    {
        public Guid TransportId { get; set; }
        public string TransportType { get;  set; }
        public DateTime StartTime { get;  set; }
        public DateTime EndTime { get;  set; }

/*        public Transport( AutoType transportType, DateTime startTime, DateTime endTime)
        {
        
            TransportType = transportType;
            StartTime = startTime;
            EndTime = endTime;
        }*/

        public override string ToString()
        {
            return  $"Your Transpotr Id : {TransportId} \n Your transport type : {TransportType}; \n Your Enterance Time:  {StartTime}; \n Your Exit Time: {EndTime}  \n ";
        }
    }
}
