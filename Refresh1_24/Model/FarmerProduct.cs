using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    [PrimaryKey(nameof(FarmerId), nameof(ProductId))]

    internal class FarmerProduct
    {
        public required int FarmerId { get; set; }
        public required int ProductId { get; set; }
        public required Farmer Farmer { get; set; }
        public required Product Product { get; set; }

    }
}
