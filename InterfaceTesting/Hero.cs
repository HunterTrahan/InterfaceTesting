using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
    class Hero : IPrintable
    {
        int _health = 0;

        public void Print()
        {
            _health = 100;
            Console.WriteLine(_health);
        }
    }
}
