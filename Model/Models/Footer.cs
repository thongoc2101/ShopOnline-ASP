using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // cho bieets bien ID nay tu tang
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }

    }
}
