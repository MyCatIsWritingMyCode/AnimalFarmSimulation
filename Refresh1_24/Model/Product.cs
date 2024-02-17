using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Value { get; set; }
        public string? Description { get; set; }
        //public ICollection<Animal>? Animals { get; set; } = null;
        //public ICollection<Farmer>? Farmers { get; set; } = null;
        public ICollection<FarmerProduct>? FarmerProduct { get; set; } = null;
        public ICollection<AnimalProduct>? AnimalProduct { get; set; } = null;
    }
}
