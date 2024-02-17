using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    [PrimaryKey(nameof(FarmerId), nameof(ItemId))]

    internal class FarmerItem
    {
        public required int FarmerId { get; set; }
        public required int ItemId { get; set; }
        public required Farmer Farmer { get; set; }
        public required Item Item { get; set; }
    }
}
