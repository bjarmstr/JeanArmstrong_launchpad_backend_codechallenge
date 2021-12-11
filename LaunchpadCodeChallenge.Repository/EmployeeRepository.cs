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

        public async Task<List<Employee>> GetAll()
        {
            var results = await _context.Employees
                .ToListAsync();
            return results;

        }


    }
}
