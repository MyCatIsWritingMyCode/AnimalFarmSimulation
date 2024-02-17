using Microsoft.EntityFrameworkCore;
using Refresh1_24.Data;
using Refresh1_24.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Repository
{
    internal class AnimalRepository : IAnimalRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<Animal> _dbSet;
        public AnimalRepository(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<Animal>();
        }

        public ICollection<Animal> GetAll()
        {
            return _dbSet.ToList();
        }

        public Animal GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Add(Animal animal)
        {
            _dbSet.Add(animal);
        }

        public void Delete(int id)
        {
            _dbSet.Remove(GetById(id));
        }
        public void Update(Animal animal)
        {
            _context.Entry(animal).State = EntityState.Modified;
        }
    }
}
