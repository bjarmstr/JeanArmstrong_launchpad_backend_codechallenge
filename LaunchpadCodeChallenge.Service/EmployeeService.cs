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

            
        //for Question 3 and 6
        //I should have clarified --  Can I put public out the front?  Can I make it async?
        IEnumerable<Employee> GetAll()
        {
            var results = _employeeRepository.GetAll();
            
            return results;
        }
        //public method to access private method
        public IEnumerable<Employee> GetAllPublic()
        {
           return GetAll();
        }

        //for Question 3 and 6
        //clarification -make a private and public method  if public is not allowed
        public IList<Employee> ListAll()
        {
            ///** this is returning a list
            var results =  _employeeRepository.ListAll();
            //results is a list

            return results;
        }


        //for Question 4a
        public async Task<List<EmployeeVM>> ListAllAysnc()
        {
            var results = await _employeeRepository.ListAllAsync();
            //results is a list

            //Return a ViewModel so Entity is not exposed to endpoint
            //mapping of Employee to EmployeeVM is in EmployeeVM constructor
            var models = results.Select(employee => new EmployeeVM(employee)).ToList();
            return models;
        }


        //for Question 4b
        public async Task<List<EmployeeVM>> GetByDepartment(Guid departmentId)
        {
            var results = await _employeeRepository.GetByDepartment(departmentId);

            //mapping of Employee to EmployeeVM is in EmployeeVM constructor
            var models = results.Select(employee => new EmployeeVM(employee)).ToList();
           
            return models;
        }

    }
}
