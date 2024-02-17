using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    [PrimaryKey(nameof(AnimalId), nameof(ProductId))]
    internal class AnimalProduct
    {

        public int AnimalId { get; set; }
        public int ProductId { get; set; }
        public Animal? Animal { get; set; }
        public Product? Product { get; set; }
    }
}
