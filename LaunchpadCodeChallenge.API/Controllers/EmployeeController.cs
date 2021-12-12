using LaunchpadCodeChallenge.Models.ViewModels;
using LaunchpadCodeChallenge.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<List<EmployeeVM>> ListAll()
        {
            var results = _employeeService.ListAll();
            return Ok(results);
        }

        [HttpGet("getall")]
        public ActionResult<List<EmployeeVM>> GetAll()
        {
            var results = _employeeService.GetAll();

            return Ok(results);
        }

        [HttpPost("listing")]
        public async Task<ActionResult<EmployeeVM>> Create([FromBody] EmployeeCreateVM data)
        {



            var result = await _employeeService.Create(data);
            return Ok(result);
        }

    }
}
