using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace store.Models
{
    public class ReturnInfo
    {
        public virtual int ID { get; set; }
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


        public virtual Order OriginalOrder { get; set; }
        public virtual DateTime DateToReturnBy { get; set; }
        public virtual DateTime DateReturnReceived { get; set; }
        public virtual ReturnReason Reason { get; set; }


    }
}
