using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class CCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
