using eWireApi.Entities.Models;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    public interface IAccountService
    {
        Task<AccountDetails> GetAccountDetails(CustomerRequest customerRequest);
        Task<AccountBalance> GetAccountBalance(AccountBalanceRequest customerRequest);
    }
}
