namespace eWireApi.Entities.Models
{
    public class MiniStatementRequest : AccountBalanceRequest
    {
        public int PageNumber { get; set; }
        public int NoRows { get; set; }
    }
}
