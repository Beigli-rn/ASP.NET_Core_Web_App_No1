using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StudentManagerSteps.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Firstname")]
        public string firstName { get; set; }
        [Required]
        [DisplayName("Lastname")]
        public string lastName { get; set; }
        [Required]
        [DisplayName("City")]
        public string city { get; set; }
        [Required]
        [DisplayName("Zip code")]
        public string zipcode { get; set; }
    }
}
