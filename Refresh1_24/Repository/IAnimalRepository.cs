using Refresh1_24.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Repository
{
    //groundwork for the repository pattern
    internal interface IAnimalRepository
    {
        Animal GetById(int id);
        ICollection<Animal> GetAll();
        void Add(Animal entity);
        void Update(Animal entity);
        void Delete(int id);
    }
}
