using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    //base class for all animals
    internal abstract class Animal
    {
        public virtual int Id { get; private set; }
        [Required]
        public virtual string? Name { get; set; }
        public virtual int Price { get; set; }
        public virtual DateTime? birthday { get; set; }
        //public ICollection<Product>? Products { get; set; } = null;
        //public ICollection<Farmer>? Farmers { get; set; } = null;
        public ICollection<AnimalFarmer>? AnimalOwner { get; set; } = null;
        public ICollection<AnimalProduct>? AnimalProduct { get; set; } = null;


    }
}
