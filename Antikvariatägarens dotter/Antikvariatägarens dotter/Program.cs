using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antikvariatägarens_dotter
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book(); //Skapar instanser av både book och customers så att de kan kallas här
            Customers c = new Customers();

            b.PrintInfo(); //test
        }
    }
}
