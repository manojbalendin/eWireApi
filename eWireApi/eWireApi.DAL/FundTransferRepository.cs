using eWireApi.Entities.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace eWireApi.DAL
{
    public class FundTransferRepository : IFundTransferRepository
    {
        protected readonly IConfiguration _config;
        public FundTransferRepository(IConfiguration config)
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
        public async Task<FundTransfer> FundTransfer(FundTransferRequest fundTransferRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<FundTransfer> HoldBalance(FundTransferRequest fundTransferRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<List<MiniStatement>> MiniStatement(MiniStatementRequest miniStatementRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<FundTransfer> ReverseFundTransfer(FundTransferRequest fundTransferRequest)
        {
            throw new NotImplementedException();
        }

        public async Task<FundTransfer> ReverseHoldBalance(FundTransferRequest fundTransferRequest)
        {
            throw new NotImplementedException();
        }
    }
}
