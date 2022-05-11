using eWireApi.DAL;
using eWireApi.Entities.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    public class CustomerService : ICustomerService
    {
        protected readonly ICustomerRepository _customerRepository;
        protected readonly IConfiguration _config;
        public CustomerService(ICustomerRepository customerRepository, IConfiguration config)
        {
            _customerRepository = customerRepository;
            _config = config;
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
        public void TestMethod()
        {
            dynamic param = new
            {
                FirstName ="Man",
                LastName = "Siingh",
                Mobile ="!234567899",
                UserName = "utest",
                Password ="1234" ,
                Email="abcl@gmail.com"
            };
            dynamic param1 =new 
            {
                SchoolId = 84,
                Name = "abc",
                Code = 1,
                SemesterCount = 5
            };
            using (SQLDataAccess sql = new SQLDataAccess(_config))
            {
                try
                {
                    sql.StartTransaction();
                    sql.SaveDataInTransaction("InsUsersSP", param);
                    sql.SaveDataInTransaction("InsCourseSP", param1);
                    var res = sql.LoadDataInTransaction<dynamic,dynamic>("GetUsersSP", new {Id = 1});
                    sql.CommitTransaction();
                }
                catch (Exception ex)
                {
                    sql.RollbackTransaction();
                    throw;
                }


            }
        }
    }
}
