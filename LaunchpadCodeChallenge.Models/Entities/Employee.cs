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
        [Key]
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string JobTitle { get; set; }

        public string Address { get; set; }

        public string DepartmentId { get; set; }
        
        public Department Department { get; set; }



    }
}
