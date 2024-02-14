using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    internal class Sheep : Animal, IFarmAnimal
    {
        string[] IFarmAnimal.Products => new string[] { "wool", "meat", "bones" };
    }
}
