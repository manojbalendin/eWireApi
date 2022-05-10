using eWireApi.DAL;
using eWireApi.Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eWireApi.Service
{
    public class FundTransferService : IFundTransferService
    {
        protected readonly IFundTransferRepository _fundTransferRepository;
        public FundTransferService(IFundTransferRepository fundTransferRepository)
        {
            _fundTransferRepository = fundTransferRepository;
        }
        public async Task<FundTransfer> FundTransfer(FundTransferRequest fundTransferRequest)
        {
            FundTransfer fundTransfer = await _fundTransferRepository.FundTransfer(fundTransferRequest);
            return fundTransfer;
        }

        public async Task<FundTransfer> HoldBalance(FundTransferRequest fundTransferRequest)
        {
            FundTransfer fundTransfer = await _fundTransferRepository.HoldBalance(fundTransferRequest);
            return fundTransfer;
        }

        public async Task<List<MiniStatement>> MiniStatement(MiniStatementRequest miniStatementRequest)
        {
            List<MiniStatement> miniStatements = await _fundTransferRepository.MiniStatement(miniStatementRequest);
            return miniStatements;
        }

        public async Task<FundTransfer> ReverseFundTransfer(FundTransferRequest fundTransferRequest)
        {
            FundTransfer fundTransfer = await _fundTransferRepository.ReverseFundTransfer(fundTransferRequest);
            return fundTransfer;
        }

        public async Task<FundTransfer> ReverseHoldBalance(FundTransferRequest fundTransferRequest)
        {
            FundTransfer fundTransfer = await _fundTransferRepository.ReverseHoldBalance(fundTransferRequest);
            return fundTransfer;
        }
    }
}
