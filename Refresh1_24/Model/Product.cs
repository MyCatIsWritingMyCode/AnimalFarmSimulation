using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    internal class Product
    {
        public string? Name { get; private set; }
        public int Value { get; private set; }
        public string? Description { get; private set; }
    }
}
