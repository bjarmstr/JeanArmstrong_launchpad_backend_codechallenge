using LaunchpadCodeChallenge.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchpadCodeChallenge.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            

            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    Id = new Guid("7a5052a2-f0d2-4870-91e1-2d47dcce91a0"),
                    Name = "Engineering",
                    Address = "5th floor",
                },
                new Department
                {
                    Id = new Guid("32765d3e-4e43-41a3-8177-4409cb508b7a"),
                    Name = "Administration",
                    Address = "7th floor",
                }
              

            );


            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = Guid.NewGuid(),
                               FirstName = "Vivi",
                               LastName = "Jones",
                               JobTitle = "Software Developer",
                               Address = "123 My Street",
                               DepartmentId = new Guid("7a5052a2-f0d2-4870-91e1-2d47dcce91a0")
                },
                new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Jack",
                    LastName = "Brown",
                    JobTitle = "Software Developer",
                    Address = "345 23rd St, NE",
                    DepartmentId = new Guid("7a5052a2-f0d2-4870-91e1-2d47dcce91a0")
                }, new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "John",
                    LastName = "Smith",
                    JobTitle = "Receptionist",
                    Address = "19934 15 Ave, NE",
                    DepartmentId = new Guid("32765d3e-4e43-41a3-8177-4409cb508b7a")
                }, new Employee
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Millie",
                    LastName = "Peterson",
                    JobTitle = "Software Architect",
                    Address = "4532 Briar Hill Way, SW",
                    DepartmentId = new Guid("7a5052a2-f0d2-4870-91e1-2d47dcce91a0")
                }
            );
        }

    }
}
