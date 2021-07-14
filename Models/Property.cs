using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstateListing.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Available { get; set; }
        public DateTime? BuiltIn { get; set; }
        public int? Price { get; set; }
        public string Owner { get; set; }
        public string Address { get; set; }
    }
}
