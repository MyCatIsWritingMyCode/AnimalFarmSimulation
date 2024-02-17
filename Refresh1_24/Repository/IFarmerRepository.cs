using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refresh1_24.Model;

namespace Refresh1_24.Repository
{
    internal interface IFarmerRepository
    {
        Farmer GetFarmerById(int id);
        ICollection<Farmer> GetAllFarmer();
        void Add(Farmer farmer);
        void Update(Farmer farmer);
        void Delete(Farmer farmer);
    }
}
