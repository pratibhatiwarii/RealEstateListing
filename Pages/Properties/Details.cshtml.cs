using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RealEstateListing.Data;
using RealEstateListing.Models;

namespace RealEstateListing.Pages.Properties
{
    public class DetailsModel : PageModel
    {
        private readonly RealEstateListing.Data.RealEstateListingContext _context;

        public DetailsModel(RealEstateListing.Data.RealEstateListingContext context)
        {
            _context = context;
        }

        public Property Property { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Property = await _context.Property.FirstOrDefaultAsync(m => m.Id == id);

            if (Property == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
