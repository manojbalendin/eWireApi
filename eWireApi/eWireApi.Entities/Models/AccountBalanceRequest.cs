namespace eWireApi.Entities.Models
{
    public class AccountBalanceRequest : CustomerRequest
    {
        public int CustId { get; set; }
        public int AccNo { get; set; }
    }
}
