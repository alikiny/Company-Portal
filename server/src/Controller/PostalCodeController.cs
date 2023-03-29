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
    [Route("api/v1/postal_codes")]
    public class PostalCodeController : ControllerBase
    {
        private readonly ICompanyService _service;
        public PostalCodeController(ICompanyService service)
        {
            _service = service;
        }

        [HttpGet("{postCode}/companies")]
        public async Task<ActionResult<Company>> GetCompaniesByCode([FromRoute] string postCode)
        {
            return Ok(await _service.GetByPostCodeAsycn(postCode));
            // return Ok();
        }
    }
}