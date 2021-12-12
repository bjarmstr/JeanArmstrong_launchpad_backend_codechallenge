using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.ViewModels
{
    public class EmployeeCreateVM
    {
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
        /// Name of Department that employee is assigned to
        /// </summary>
        

       


    }
}
