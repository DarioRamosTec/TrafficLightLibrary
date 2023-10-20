using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLightLibrary
{
    class Semaforo
    {
        public Semaforo ()
        {

        }
    }

    public class Lector
    {
        Thread thread;
        private Func<bool> threadTo;
        public Func<bool> ThreadTo { get => threadTo; set => threadTo = value; }

        public Lector ()
        {
            SetThread(new Func<bool>(() => {
                    return false;
                }
            ));
        }

        public Lector(Func<bool> func)
        {
            SetThread(func);
        }

        public void SetThread(Func<bool> funToEstablish)
        {
            threadTo = funToEstablish;
        }

        public void Start()
        {
            thread = new Thread(ThreadDo);
            thread.Start();
        }

        public void ThreadDo()
        {
            bool stateThread = true;
            while (stateThread)
            {
                stateThread = ThreadTo();
            }
        }
    }
}
