using System.ComponentModel.DataAnnotations;

namespace WebSalesMvc.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Categoria")]
        public Category Category { get; set; }

        public int CategoryId { get; set; }

        [Display(Name = "Departamento")]
        public Department Department { get; set; }
       
        public int DepartmentId { get; set; }
      
        [Display(Name = "Imagem")]
        public string ImageUrl { get; set; }
    }
}
