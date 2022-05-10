using eWireApi.Entities.Models;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public interface IAccountRepository
    {
        Task<AccountDetails> GetAccountDetails(CustomerRequest customerRequest);
        Task<AccountBalance> GetAccountBalance(AccountBalanceRequest customerRequest);
    }
}
