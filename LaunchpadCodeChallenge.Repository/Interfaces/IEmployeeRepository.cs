using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();

        IList<Employee> ListAll();

        Task<Employee> Create(Employee src);
    }
}
