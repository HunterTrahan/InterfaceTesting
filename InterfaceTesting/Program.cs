using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            Item item = new Item();

            item.Print();
            hero.Print();

            Console.ReadLine();
        }
    }

}
