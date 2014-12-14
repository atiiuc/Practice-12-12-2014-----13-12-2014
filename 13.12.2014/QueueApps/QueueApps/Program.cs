using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueApps
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue < String > myQ= new Queue<String>();
            myQ.Enqueue("Amena");
             myQ.Enqueue("Tasneem");
            myQ.Enqueue("XX");
            myQ.Enqueue("yy");
            myQ.Enqueue("ZZ");
            Console.WriteLine(myQ.Dequeue());
            Console.ReadLine();

        }
    }
}
