using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class Cable : Socket
    {
        private Bulb bulb;

        public Cable(Bulb bulb)
        {
            this.bulb = bulb;
        }

        public void SwitchOff()
        {
            bulb.LightOff();
        }

        public void SwitchOn()
        {
            bulb.LightOn();
        }
    }
}
