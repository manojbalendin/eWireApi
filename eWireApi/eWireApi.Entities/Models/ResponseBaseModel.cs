namespace eWireApi.Entities.Models
{
    public class ResponseBaseModel
    {
        public string TrackerId { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
    }
}
