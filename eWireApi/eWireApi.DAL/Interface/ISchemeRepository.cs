using eWireApi.Entities.Models;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public interface ISchemeRepository
    {
        Task<SchemeDetails> SchemeDetails(RequestBaseModel request);
    }
}
