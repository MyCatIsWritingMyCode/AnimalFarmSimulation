using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    internal class Farmer
    {
        public int Id { get; private set; }
        [Required]
        public string? Name { get; private set; }
        public int Coins { get; set; }
        public int FarmerLevel { get; set; }
        //public virtual ICollection<Product>? Products { get; set; } = null;
        //public virtual ICollection<Animal>? Animals { get; set; } = null;
        //public virtual ICollection<Item>? Items { get; set; } = null;
        public virtual ICollection<FarmerItem>? FarmerItem { get; set; } = null;
        public virtual ICollection<FarmerProduct>? FarmerProduct { get; set; } = null;
        public virtual ICollection<AnimalFarmer>? AnimalOwner { get; set; } = null;
        public required Account Account { get; set; }
    }
}
