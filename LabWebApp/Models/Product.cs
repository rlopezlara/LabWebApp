using System.ComponentModel.DataAnnotations;

namespace LabWebApp.Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Display(Name = "First Name")]

        public decimal Price { get; set; }

        public string Description { get; set; }
       
    }

}
