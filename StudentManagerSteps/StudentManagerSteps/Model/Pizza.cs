using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentManagerSteps.Model
{
    public class Pizza
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Description")]
        public string Description { get; set; }
        [Required]
        [DisplayName("Price")]
        public int Price { get; set; }
        
    }
}
