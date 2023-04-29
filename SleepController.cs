using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example
{
    class SleepController : ISleep
    {
        public bool isSleeping { get; private set; }

        public void ToggleSleep()
        {
            isSleeping = !isSleeping;
        }
    }
}
