using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje3
{
    class Program
    {
        static void Main(string[] args)
        {
            Gepard g = new Gepard();

            bool opasna=false;

            g.Opasnost(opasna);

            Console.ReadKey();
        }
    }
}
