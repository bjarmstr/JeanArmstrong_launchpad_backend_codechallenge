using LaunchpadCodeChallenge.Models.Entities;
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
    /// <summary>
    /// endpoints for employee details 
    /// </summary>
    [Route("api/employees")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// Get details as a list for all employees
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<EmployeeVM>>> ListAllAsync()
        {
            var results = await _employeeService.ListAllAysnc();
            return Ok(results);
        }

        /// <summary>
        /// Test endpoint for IList
        /// Doesn't have async and exposes Employee so not recommended for production
        /// </summary>
        /// <returns></returns>
        [HttpGet("listall")]
        public ActionResult<List<Employee>> ListAll()
        {
            var results = _employeeService.ListAll();
            return Ok(results);
        }

        /// <summary>
        /// Test endpoint to for IEnumerable GetAll Service
        /// Doesn't have async and exposes Employee not recommended for production
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public ActionResult<List<Employee>> GetAll()
        {
            var results = _employeeService.GetAllPublic();
            return Ok(results);
        }

        /// <summary>
        /// Get employees in a given department
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        [HttpGet("department/{departmentId}")]
        public async Task<ActionResult<List<EmployeeVM>>> GetByDepartment([FromRoute]Guid departmentId)
        {
            var results = await _employeeService.GetByDepartment(departmentId);
            return Ok(results);
        }

    }
}
