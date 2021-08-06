using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee 
                { 
                    Id = 1, Name = "Ashley", Email = "Ashleyc97@outlook.com", 
                    Department = Dept.IT 
                }
            );
        }
    }
}
