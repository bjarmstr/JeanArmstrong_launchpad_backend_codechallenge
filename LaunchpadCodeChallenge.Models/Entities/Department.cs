using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Models.Entities
{
    public class Department
    {
        /// <summary>
        /// Guid Identifier - Uniquely Identifies the Department
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Department Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Each Department has a Unique Address
        /// </summary>
        [Key]
        [Required]
        public string Address { get; set; }

        /// <summary>
        /// Employees in the Department
        /// </summary>
        public List<Employee> Employees { get; set; }
    }
}
