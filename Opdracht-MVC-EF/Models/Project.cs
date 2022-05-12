using System.ComponentModel.DataAnnotations;

namespace Opdracht_MVC_EF.Models
{
    public class Project
    {
        public int ProjectID { get; set; }

        [MaxLength(50,ErrorMessage = "Maximum Length is 50 characters.")]
        [Display(Name ="Project Name")]
        public string Name { get; set; }
    }
}
