using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstateListing.Models;

namespace RealEstateListing.Data
{
    public class RealEstateListingContext : DbContext
    {
        public RealEstateListingContext (DbContextOptions<RealEstateListingContext> options)
            : base(options)
        {
        }

        public DbSet<RealEstateListing.Models.Property> Property { get; set; }
    }
}
