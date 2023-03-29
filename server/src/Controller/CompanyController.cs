using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.src.Models;
using server.src.Service;

namespace server.src.Controller
{
    [ApiController]
    [Route("api/v1/[controller]s")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _service;
        public CompanyController(ICompanyService service)
        {
            _service = service;

        }
        [HttpPost()]
        public async Task<ActionResult<IEnumerable<Company>>> AddCompaniesAsync(IEnumerable<Company> companies)
        {
            return Ok(await _service.AddCompaniesAsync(companies));
        }
    }
}