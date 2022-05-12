using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Opdracht_MVC_EF.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [MaxLength(50,ErrorMessage ="Maximum Length is 50 characters.")]
        [Display(Name ="Department Name")]
        public string Name { get; set; }
    }
}
