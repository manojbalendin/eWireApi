using eWireApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public interface IeWireApiRepository
    {
        Task<IEnumerable<DemoEntities>> Get();
        void Add(DemoEntities entity);
        void Update(DemoEntities entity);
        void Remove(int id);
    }
}
