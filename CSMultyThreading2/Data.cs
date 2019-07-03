using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSMultyThreading2
{
    class Data
    {
        public int State { get; private set; } = 1;

        public void SayHello()
        {
            Console.Write("Hello ");
            State = 2;
        }

        public void SayWorld()
        {
            Console.Write("World");
            State = 3;
        }

        public void End()
        {
            Console.WriteLine("!");
            State = 1;
        }    
    }
}
