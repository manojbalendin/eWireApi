using eWireApi.Entities.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        protected readonly IConfiguration _config;
        public CustomerRepository(IConfiguration config)
        {
            _config = config;
        }
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }
        public async Task<ResponseBaseModel> CustomerOnboard(CustomerRequest customerRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomerDetails> GetCustomerDetails(CustomerRequest customerRequest)
        {
            throw new NotImplementedException();
        }
    }
}
