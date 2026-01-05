using System.ComponentModel.DataAnnotations;

namespace Skoppers.Models.Product
{
    public class Product:BaseModel
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Image {  get; set; }

    }
}
