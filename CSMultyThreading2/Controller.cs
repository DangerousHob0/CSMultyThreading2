using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSMultyThreading2
{
    class Controller
    {     
        public Data data;
        public int id;

        public void DoWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Monitor.Enter(data);

                while (id != data.State)
                    Monitor.Wait(data);    

                if (id == 1)
                    data.SayHello();
                else if (id == 2)
                    data.SayWorld();
                else
                    data.End();

                Monitor.PulseAll(data);
                Monitor.Exit(data);              
            }
        }
    }
}