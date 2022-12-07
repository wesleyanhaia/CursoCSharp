using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oioi
{

    static void Main(string[] args)
    {
       
        for(int i = 0; i<5; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("Passou 1 segundo.");
        }
        Console.ReadKey();

    }
}
