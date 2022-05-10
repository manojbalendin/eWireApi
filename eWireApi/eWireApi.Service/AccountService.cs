using eWireApi.DAL;
using eWireApi.Entities.Models;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    public class AccountService : IAccountService
    {
        protected readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountBalance> GetAccountBalance(AccountBalanceRequest customerRequest)
        {
            AccountBalance accountBalance = await _accountRepository.GetAccountBalance(customerRequest);
            return accountBalance;
        }

        public async Task<AccountDetails> GetAccountDetails(CustomerRequest customerRequest)
        {
            AccountDetails accountDertails = await _accountRepository.GetAccountDetails(customerRequest);
            return accountDertails;
        }
    }
}
