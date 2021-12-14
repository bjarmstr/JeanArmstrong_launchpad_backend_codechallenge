using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LaunchpadCodeChallenge.Models.Entities
{
    /// <summary>
    /// Class for Department DbSet
    /// </summary>
    [Index(nameof(Address), IsUnique = true)]
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
        public string Address { get; set; }

        /// <summary>
        /// Employees in the Department
        /// </summary>
        public List<Employee> Employees { get; set; }
    }
}
