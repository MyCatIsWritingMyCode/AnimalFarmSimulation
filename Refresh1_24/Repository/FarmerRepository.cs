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
    internal class FarmerRepository : IFarmerRepository
    {
        private readonly DataContext _context;
        private readonly DbSet<Farmer> _dbSet;
        public FarmerRepository(DataContext context)
        {
            _context = context;
            _dbSet = context.Set<Farmer>();
        }

        public ICollection<Farmer> GetAllFarmer()
        {
            return _dbSet.ToList();
        }
        public void Add(Farmer farmer)
        {
            _dbSet.Add(farmer);
        }

        public void Delete(Farmer farmer)
        {
            _dbSet.Remove(farmer);
        }

        public Farmer GetFarmerById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Update(Farmer farmer)
        {
            _context.Entry(farmer).State = EntityState.Modified;
        }
    }
}
