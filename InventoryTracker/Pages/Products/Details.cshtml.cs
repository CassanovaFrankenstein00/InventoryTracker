using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using InventoryTracker.Data;
using InventoryTracker.Models;

namespace InventoryTracker.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryTracker.Data.InventoryTrackerContext _context;

        public DetailsModel(InventoryTracker.Data.InventoryTrackerContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);
            var product = await _context.Product
                         .Include(p => p.Category) // Include the related Category data
                         .FirstOrDefaultAsync(m => m.Id == id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                Product = product;
            }
            return Page();
        }
    }
}
