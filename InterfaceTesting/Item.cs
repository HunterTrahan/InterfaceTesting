using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
    class Item : IPrintable
    {
        int _damage = 0;

        public void Print()
        {
            _damage = 10;
            Console.WriteLine(_damage);
        }
    }
}
