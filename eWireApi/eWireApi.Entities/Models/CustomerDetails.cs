namespace eWireApi.Entities.Models
{
    public class CustomerDetails : ResponseBaseModel
    {
        public string CustAddr { get; set; }
        public int CustId { get; set; }
        public double CustMobile { get; set; }
        public string CustName { get; set; }
    }
}
