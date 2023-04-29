using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example
{
    interface IPowerOn
    {
        bool isOn { get; }
        void TogglePower();

    }
}
