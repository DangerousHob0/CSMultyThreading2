using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSMultyThreading2
{
    class Program
    {
        static void Main(string[] args)
        {
            Data shareData = new Data();

            new Thread(new Controller() { data = shareData, id = 1 }.DoWork).Start();
            new Thread(new Controller() { data = shareData, id = 2 }.DoWork).Start();
            new Thread(new Controller() { data = shareData, id = 3 }.DoWork).Start();
        }
    }
}
