using eWireApi.Entities.Models;
using eWireApi.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace eWireApi.Controllers
{
    [Route("Scheme")]
    [ApiController]
    public class SchemeController : ControllerBase
    {
        protected readonly IRepositoryService _repositoryService;
        public SchemeController(IRepositoryService repositoryService)
        {
            this._repositoryService = repositoryService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> SchemeDetails(RequestBaseModel request)
        {
            var results = await _repositoryService._schemeService.SchemeDetails(request);
            return Ok(results);
        }
    }
}
