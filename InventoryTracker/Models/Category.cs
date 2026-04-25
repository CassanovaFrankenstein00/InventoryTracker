using System.ComponentModel.DataAnnotations;

namespace InventoryTracker.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        [StringLength(25)]
        public string Name { get; set; } = string.Empty;

        // Navigation property
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}