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
        Task<List<Employee>> GetAll();
    }
}
