using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Model.Abstract;

namespace Model.Models
{
    public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        // thêm thuộc tinh này để chỉ định rõ hon kiểu dữ liệu của Alias là varchar.
        // ( Vì nó có thể 
        // có dữ liệu là varchar hay nvarchar
        [Column(TypeName = "varchar")] 
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        public string Content { get; set; }
    }
}
