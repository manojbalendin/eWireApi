using static eWireApi.Entities.Enums.Enums;

namespace eWireApi.Entities.Models
{
    //Same used for 'ReverseFundTransfer, HoldBalance and ReverseHoldBalance' Requests
    public class FundTransferRequest : AccountBalanceRequest
    {
        public double Amount { get; set; }
        public TransactionTypes TransactionType { get; set; } 
        public int EwireTxnNo { get; set; }
    }
}
