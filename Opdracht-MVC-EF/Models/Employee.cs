using System.ComponentModel.DataAnnotations;

namespace Opdracht_MVC_EF.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum Length is 50 characters.")]
        [Display(Name ="Employee Name")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum Length is 50 characters.")]
        [Display(Name = "Employee Department")]
        public virtual string Department { get; set; }

        [MaxLength(50, ErrorMessage = "Maximum Length is 50 characters.")]
        [Display(Name = "Employee Address")]
        public virtual string EmployeeAddress { get; set; }
    }
}
