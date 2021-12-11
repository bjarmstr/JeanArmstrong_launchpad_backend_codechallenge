using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Service
{
    public class EmployeeService: IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService( IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetAll()
        {

        }

        public IList<Employee> ListAll()
        {

        }

    }
}
