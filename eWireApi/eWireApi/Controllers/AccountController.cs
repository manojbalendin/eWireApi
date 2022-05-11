using eWireApi.Entities.Models;
using eWireApi.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eWireApi.Controllers
{
    [Route("Account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        protected readonly IRepositoryService _repositoryService;
        public AccountController(IRepositoryService repositoryService)
        {
            this._repositoryService = repositoryService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetCourses(CustomerRequest customerRequest)
        {
            var results = await _repositoryService._accountService.GetAccountDetails(customerRequest);
            return Ok(results);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetAccountBalance(AccountBalanceRequest accountBalanceRequest)
        {
            var results = await _repositoryService._accountService.GetAccountBalance(accountBalanceRequest);
            return Ok(results);
        }
    }
}
