using eWireApi.Entities.Models;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public interface ICustomerRepository
    {
        Task<ResponseBaseModel> CustomerOnboard(CustomerRequest customerRequest);
        Task<CustomerDetails> GetCustomerDetails(CustomerRequest customerRequest);
    }
}
