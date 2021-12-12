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
        IEnumerable<Employee> GetAllPublic();
        //IEnumerable<Employee> GetAll();

        IList<Employee> ListAll();

        Task<List<EmployeeVM>> ListAllAysnc();

        Task<List<EmployeeVM>> GetByDepartment(Guid departmentId);
    }
}
