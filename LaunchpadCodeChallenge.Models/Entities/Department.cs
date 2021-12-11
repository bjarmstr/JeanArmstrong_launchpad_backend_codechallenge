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
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Address is unique
        /// </summary>
        [Key]
        public string Address { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
