using eWireApi.Entities.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public class AccountRepository : IAccountRepository
    {
        protected readonly IConfiguration _config;
        public AccountRepository(IConfiguration config)
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

        public async Task<AccountBalance> GetAccountBalance(AccountBalanceRequest customerRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<AccountDetails> GetAccountDetails(CustomerRequest customerRequest)
        {
            throw new NotImplementedException();
        }
    }
}
