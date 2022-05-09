using eWireApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    public interface IeWireApiService
    {
        Task<IEnumerable<DemoEntities>> Get();
    }
}