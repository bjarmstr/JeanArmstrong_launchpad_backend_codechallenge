using LaunchpadCodeChallenge.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.ViewModels
{
    /// <summary>
    /// View Model for Employee Entity
    /// </summary>
    public class EmployeeVM
    {

        /// <summary>
        /// EmployeeVM default constructor
        /// </summary>
        public EmployeeVM()
        {

        }

        /// <summary>
        ///Build EmployeeVM from Employee Entity
        /// </summary>
        public EmployeeVM(Employee src)
        {
            Id = src.Id;
            FirstName = src.FirstName;
            LastName = src.LastName;
            JobTitle = src.JobTitle;
            Address = src.Address;
            DepartmentId = src.DepartmentId;
            DepartmentName = src.Department.Name;
        }



        /// <summary>
        /// Unique Identifier
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// First Name of Employee
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last Name of Employee
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Job Title for Employee
        /// </summary>
        public string JobTitle { get; set; }

        /// <summary>
        /// Mailing Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Unique identifier for Department
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Name of Department that employee is assigned to
        /// </summary>
        public string DepartmentName { get; set; }

       


    }
}
