using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    [PrimaryKey(nameof(AnimalId),nameof(FarmerId))]
    internal class AnimalFarmer
    {
        public int AnimalId { get; set; }
        public int FarmerId { get; set; }
        public Animal? Animal { get; set; } = null;
        public Farmer? Farmer { get; set; } = null;
    }
}
