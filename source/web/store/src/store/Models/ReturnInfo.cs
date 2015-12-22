using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class ReturnInfo
    {
        public enum ReturnReason
        {
            Defective,
            WrongSize,
            DeliveredLate,
            OrderedByMistake,
            NotOrdered,
            WrongColor,
            PackageBroken,
            ProductBrokenInTransit,
        }


        public Order OriginalOrder { get; set; }
        public DateTime DateToReturnBy { get; set; }
        public DateTime DateReturnReceived { get; set; }
        public ReturnReason Reason { get; set; }


    }
}
