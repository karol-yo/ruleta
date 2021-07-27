using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Table
    {   private Random _random = new(1);
        public List<User> Players = new();
        public int HowMuch { get; set; }
        public int Losuj()
        {
            return _random.Next(1, 36);
        }
    }
}
