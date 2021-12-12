using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        
        //For Question 6
        public IEnumerable<Employee> GetAll()
        {
            //.AsEnumerable can create cyclical loading issues
            // if acesss to Department details is required 
            //use JsonSerializerOptions (commented out in Startup.cs)
            var results = _context.Employees
                .AsEnumerable(); 
            return results;

        }


        //for Question 6
        public IList<Employee> ListAll()
        {
            var results =  _context.Employees
                .ToList();

            //A IList can not be cast from a List, so a new List is created and then each employee is added to the IList
            IList<Employee> employeesToIList = new List<Employee>();
            
            foreach (Employee emp in results)
            {
                employeesToIList.Add(emp);
            }
            
            return employeesToIList;

        }

        //For Restful API Question 4a
        public async Task<List<Employee>> ListAllAsync()
        {
            var results = await _context.Employees
               .Include(emp => emp.Department)
               .ToListAsync();

            return results;

        }

        //for Question 4b
        public async Task<List<Employee>> GetByDepartment(Guid departmentId)
        {
            var results = await _context.Employees
                .Where(emp => emp.DepartmentId == departmentId)
               .Include(emp => emp.Department)
               .ToListAsync();

            return results;

        }


    }
}
