using Refresh1_24.Data;
using Refresh1_24.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Simulation
{
    internal class Farm
    {
        DataContext _dataContext;
        IAccountRepository _accountRepository;
        IAnimalRepository _animalRepository;
        IFarmerRepository _farmerRepository;
        public  Farm()
        {
            _dataContext = new DataContext();
            _accountRepository = new AccountRepository(_dataContext);
            _animalRepository = new AnimalRepository(_dataContext);
            _farmerRepository = new FarmerRepository(_dataContext);
        }

        public void Start()
        {
            char mainMenu = ' ';
            while(mainMenu != 'x') 
            {
                Console.Clear();
                mainMenu = Console.ReadKey().KeyChar;
            }
            //accountRepository.Add(new Account 
            //{
            //    Email = "b",
            //    Username = "b",
            //    Password = "b"
            //});

            //Console.WriteLine(dataContext.Database.CanConnect());
            //_dataContext.SaveChanges();
        }

        public void DisplayInfo()
        {

        }
    }
}
