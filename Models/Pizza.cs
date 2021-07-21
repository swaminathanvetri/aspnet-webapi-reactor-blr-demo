using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    
    public class Pizza
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]+")]
        public string Name { get; set; }
        [Required]
        public bool IsGlutenFree { get; set; }
    }
}