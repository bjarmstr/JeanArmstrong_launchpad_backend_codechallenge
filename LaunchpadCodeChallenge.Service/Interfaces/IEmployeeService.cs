using LaunchpadCodeChallenge.Models.Entities;
using LaunchpadCodeChallenge.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Service.Interfaces
{
    public interface IEmployeeService
    {
        public IEnumerable<Employee> GetAll();

        public List<EmployeeVM> ListAll();

        public Task<Employee> Create(EmployeeCreateVM src);
    }
}
