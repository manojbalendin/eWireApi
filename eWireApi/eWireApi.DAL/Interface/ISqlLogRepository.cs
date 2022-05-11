using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public interface ISqlLogRepository
    {
        Task<bool> LogRequestAndResponse(string request, string response);
    }
}
