using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities
{
    public class Employee
    {
        /// <summary>
        /// Unique identifier - Guid 
        /// </summary>
        [Key]
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
        /// Department that employee is assigned to
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// Department is navigation property, which allows access to Department details
        /// </summary>
        public Department Department { get; set; }



    }
}
