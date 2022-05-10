using eWireApi.DAL;
using eWireApi.Entities.Models;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    public class CustomerService : ICustomerService
    {
        protected readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<ResponseBaseModel> CustomerOnboard(CustomerRequest customerRequest)
        {
            ResponseBaseModel response = await _customerRepository.CustomerOnboard(customerRequest);
            return response;
        }

        public async Task<CustomerDetails> GetCustomerDetails(CustomerRequest customerRequest)
        {
            CustomerDetails customerDetails = await _customerRepository.GetCustomerDetails(customerRequest);
            return customerDetails;
        }
    }
}
