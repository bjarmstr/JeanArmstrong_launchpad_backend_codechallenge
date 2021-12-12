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

        public IEnumerable<Employee> GetAll()
        {
            var results =  _context.Employees
                .Include(emp => emp.Department)
                .AsEnumerable(); ;
            return results;

        }

        public List<Employee> GetAllList()
        {
            var results = _context.Employees
                .Include(emp => emp.Department)
                .ToList();

            return results;

        }

        public async Task<Employee> Create(Employee src)
        {
            
                _context.Add(src);
                await _context.SaveChangesAsync();
                return src;
            
        }


    }
}
