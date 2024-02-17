using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    internal class Item
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }
        public int Price { get; set; }
        public int Rarity { get; set; }
        public int ItemLevel { get; set; }
        public string? Description { get; set; }
        //public virtual ICollection<Farmer>? Farmers { get; set; } = null;
        public virtual ICollection<FarmerItem>? FarmerItem { get; set; } = null;


    }
}
