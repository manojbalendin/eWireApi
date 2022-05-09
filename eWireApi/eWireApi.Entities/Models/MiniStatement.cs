using System;
using static eWireApi.Entities.Enums.Enums;

namespace eWireApi.Entities.Models
{
    public class MiniStatement : ResponseBaseModel
    {
        public double Amount { get; set; }
        public string Particulars { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public DateTime TrDate { get; set; }
    }
}
