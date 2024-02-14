using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refresh1_24.Model
{
    internal sealed class Cat : Animal
    {
        public Cat(string name, DateTime birthdate)
        {
            TimeSpan timeAlive = DateTime.UtcNow - birthdate;
            int age = (int)(timeAlive.TotalDays / 365.0);
            Age = age;
            Name = name;
        }
    }
}
