using Microsoft.AspNetCore.Mvc;
using server.src.Dtos;
using server.src.Models;
using server.src.Service;

namespace server.src.Controller
{
    [ApiController]
    [Route("api/v1/companies")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _service;
        public CompanyController(ICompanyService service)
        {
            _service = service;

        }
        [HttpPost()]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> AddCompaniesAsync([FromBody] IEnumerable<CompanyDto> companies)
        {
            return Ok(await _service.AddCompaniesAsync(companies));
        }
    }
}