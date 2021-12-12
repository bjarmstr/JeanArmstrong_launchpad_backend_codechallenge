using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.ViewModels;
using LaunchpadCodeChallenge.Repository.Interfaces;
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
            var results = _employeeRepository.GetAll();
            
            return results;
        }

        
        public List<EmployeeVM> ListAll()
        {
            ///** this is returning a list
            var results = _employeeRepository.GetAllList();
            //results is a list

            var models = results.Select(employee => new EmployeeVM(employee)).ToList();
            return models;
        }

        public async Task<Employee> Create(EmployeeCreateVM src)
        {
            var newEntity = new Employee(src);
            var result = await _employeeRepository.Create(newEntity);
            return (result);
        }

    }
}
