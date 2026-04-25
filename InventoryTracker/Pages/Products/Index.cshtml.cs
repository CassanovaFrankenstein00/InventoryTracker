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
    public class IndexModel : PageModel
    {
        private readonly InventoryTracker.Data.InventoryTrackerContext _context;

        public IndexModel(InventoryTracker.Data.InventoryTrackerContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product
                .Include(p => p.Category).ToListAsync();
        }
    }
}
