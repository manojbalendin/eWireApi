using System.Threading.Tasks;

namespace eWireApi.Service
{
    public  interface ISqlLogService
    {
        Task<bool> LogRequestAndResponse(string request, string response);
    }
}
