using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;

        [Required]
        public int Qty { get; set; } = 0;

        [StringLength(50)]
        public string Make { get; set; }

        //Foreign key
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
