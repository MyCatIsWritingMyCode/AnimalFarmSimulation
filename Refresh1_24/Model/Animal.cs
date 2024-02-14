using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    internal abstract class Animal
    {
        public virtual string Name { get; set; } = "none";
        public virtual int Age { get; set; }
        public virtual int Type { get; set; }

    }
}
