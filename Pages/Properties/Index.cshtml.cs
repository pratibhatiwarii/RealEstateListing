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
    public class IndexModel : PageModel
    {
        private readonly RealEstateListing.Data.RealEstateListingContext _context;

        public IndexModel(RealEstateListing.Data.RealEstateListingContext context)
        {
            _context = context;
        }

        public IList<Property> Property { get;set; }

        public async Task OnGetAsync()
        {
            Property = await _context.Property.ToListAsync();
        }
    }
}
