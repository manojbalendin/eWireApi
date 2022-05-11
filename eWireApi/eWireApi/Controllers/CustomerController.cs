using eWireApi.Entities.Models;
using eWireApi.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eWireApi.Controllers
{
    [Route("Customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        protected readonly IRepositoryService _repositoryService;
        public CustomerController(IRepositoryService repositoryService)
        {
            this._repositoryService = repositoryService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetCourses(CustomerRequest customerRequest)
        {
            var results = await _repositoryService._customerService.GetCustomerDetails(customerRequest);
            return Ok(results);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> CustomerOnboard(CustomerRequest customerRequest)
        {
            var results = await _repositoryService._customerService.CustomerOnboard(customerRequest);
            return Ok(results);
        }
    }
}
