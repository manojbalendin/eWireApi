using eWireApi.DAL;
using eWireApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    internal class eWireApiService : IeWireApiService
    {
        private readonly IeWireApiRepository _repository;

        public eWireApiService(IeWireApiRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<DemoEntities>> Get()
        {
            return _repository.Get();
        }
    }
}
