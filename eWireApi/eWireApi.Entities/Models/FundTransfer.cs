using System;

namespace eWireApi.Entities.Models
{
    //Same used for 'ReverseFundTransfer, HoldBalance and ReverseHoldBalance' Requests
    public class FundTransfer : ResponseBaseModel
    {
        public double TransactionRef { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
