using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_example
{
    class PowerController: IPowerOn
    {

        public bool isOn { get; private set; }

        protected void TurnOn()
        {
            isOn = true;
        }
        protected void TurnOff()
        {
            isOn = false;
        }

        public virtual void TogglePower()
        {
            if (isOn)
            {
                TurnOff();
            }
            else
            {
                TurnOn();
            }
        }
    }
}
