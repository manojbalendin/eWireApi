using eWireApi.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public interface IFundTransferRepository
    {
        Task<FundTransfer> FundTransfer(FundTransferRequest fundTransferRequest);
        Task<FundTransfer> ReverseFundTransfer(FundTransferRequest fundTransferRequest);
        Task<FundTransfer> HoldBalance(FundTransferRequest fundTransferRequest);
        Task<FundTransfer> ReverseHoldBalance(FundTransferRequest fundTransferRequest);
        Task<List<MiniStatement>> MiniStatement(MiniStatementRequest miniStatementRequest);
    }
}
