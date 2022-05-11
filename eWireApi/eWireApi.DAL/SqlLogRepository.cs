using System;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public class SqlLogRepository : ISqlLogRepository
    {
        public async Task<bool> LogRequestAndResponse(string request, string response)
        {
            throw new NotImplementedException();
        }
    }
}
