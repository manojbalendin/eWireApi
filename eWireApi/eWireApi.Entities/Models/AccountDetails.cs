namespace eWireApi.Entities.Models
{
    public class AccountDetails : ResponseBaseModel
    {
        public int AccNo { get; set; }
        public double CustId { get; set; }
        public double CustMobile { get; set; }
        public string Msg { get; set; }
        public string SchCode { get; set; }
        public string SchName { get; set; }
    }
}
