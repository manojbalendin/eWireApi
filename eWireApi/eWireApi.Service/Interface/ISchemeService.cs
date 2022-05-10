using eWireApi.Entities.Models;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    public interface ISchemeService
    {
        Task<SchemeDetails> SchemeDetails(RequestBaseModel request);
    }
}
