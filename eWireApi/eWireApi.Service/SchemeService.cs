using eWireApi.DAL;
using eWireApi.Entities.Models;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    public class SchemeService : ISchemeService
    {
        protected readonly ISchemeRepository _schemeRepository;
        public SchemeService(ISchemeRepository schemeRepository)
        {
            _schemeRepository = schemeRepository;
        }
        public async Task<SchemeDetails> SchemeDetails(RequestBaseModel request)
        {
            SchemeDetails schemeDetails = await _schemeRepository.SchemeDetails(request);
            return schemeDetails;
        }
    }
}
