using eWireApi.Entities.Models;
using eWireApi.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eWireApi.Controllers
{
    [Route("FundTransfer")]
    [ApiController]
    public class FundTransferController : ControllerBase
    {
        protected readonly IRepositoryService _repositoryService;
        public FundTransferController(IRepositoryService repositoryService)
        {
            this._repositoryService = repositoryService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> FundTransfer(FundTransferRequest fundTransferRequest)
        {
            var results = await _repositoryService._fundTransferService.FundTransfer(fundTransferRequest);
            return Ok(results);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> ReverseFundTransfer(FundTransferRequest fundTransferRequest)
        {
            var results = await _repositoryService._fundTransferService.ReverseFundTransfer(fundTransferRequest);
            return Ok(results);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> HoldBalance(FundTransferRequest fundTransferRequest)
        {
            var results = await _repositoryService._fundTransferService.HoldBalance(fundTransferRequest);
            return Ok(results);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> ReverseHoldBalance(FundTransferRequest fundTransferRequest)
        {
            var results = await _repositoryService._fundTransferService.ReverseHoldBalance(fundTransferRequest);
            return Ok(results);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> MiniStatement(MiniStatementRequest miniStatementRequest)
        {
            var results = await _repositoryService._fundTransferService.MiniStatement(miniStatementRequest);
            return Ok(results);
        }
    }
}
