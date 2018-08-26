using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // cho bieets bien ID nay tu tang
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        public int GroupID { set; get; }

        // Khoa ngoai, tro toi truong GroupID cua bang Menu
        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

        public  int? DisplayOrder { set; get; }

        [MaxLength(10)]
        public string Target { set; get; }

        [Required]
        public bool Status { set; get; }
    }
}
