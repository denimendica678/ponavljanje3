using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanje3
{
    public class Cat
    {
        bool opasna;
        public void Opasnost(bool opasna)
        {
            opasna = false;
        }

    }

    public class Gepard : Cat
    {
        public void Opasnost(bool opasna)
        {
            opasna = true;

            Console.WriteLine("Gepard je opasan." + opasna);
        }
        

    }
}
