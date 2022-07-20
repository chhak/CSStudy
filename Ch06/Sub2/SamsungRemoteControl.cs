using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class SamsungRemoteControl : IRemoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("Samsung ChDown...");
        }

        public void ChUp()
        {
            Console.WriteLine("Samsung ChUp...");
        }

        public void PowerOff()
        {
            Console.WriteLine("Samsung PowerOff...");
        }

        public void PowerOn()
        {
            Console.WriteLine("Samsung PowerOn...");
        }

        public void SoundDown()
        {
            Console.WriteLine("Samsung SoundDown...");
        }

        public void SoundUp()
        {
            Console.WriteLine("Samsung SoundUp...");
        }
    }
}
