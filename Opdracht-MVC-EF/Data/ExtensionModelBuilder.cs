using Microsoft.EntityFrameworkCore;
using Opdracht_MVC_EF.Models;

namespace Opdracht_MVC_EF.Data
{
    public static class ExtensionModelBuilder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(new Department { DepartmentID = 1, Name = "Human Resources" });
            modelBuilder.Entity<Employee>().HasData(new Employee { EmployeeID = 1, Name = "Fatih Ozer", EmployeeAddress = "Leuven", Department="Human Resources" });
            modelBuilder.Entity<Project>().HasData(new Project { ProjectID = 1, Name = "Writing a code with using Entity Framework" }); 
        }
    }
}
