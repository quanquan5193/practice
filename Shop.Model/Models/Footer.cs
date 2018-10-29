using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("Footers")]
    // using System.ComponentModel.DataAnnotations.Schema;
    public class Footer
    {
        [Key] //using System.ComponentModel.DataAnnotations;
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}