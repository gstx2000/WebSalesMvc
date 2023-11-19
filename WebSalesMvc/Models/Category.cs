using System.ComponentModel.DataAnnotations;

namespace WebSalesMvc.Models
{
    public class Category
    {    
        public int Id { get; set; }
        
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Nome obrigatório")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Departamento")]
        public Department Department { get; set; }
        public  int DepartmentId { get; set; }

        public Category()
        {
        }
    }
}
