using eWireApi.Entities.Models;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    public interface ICustomerService
    {
        Task<ResponseBaseModel> CustomerOnboard(CustomerRequest customerRequest);
        Task<CustomerDetails> GetCustomerDetails(CustomerRequest customerRequest);
    }
}
