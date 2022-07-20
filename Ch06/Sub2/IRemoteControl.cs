using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    // 인터페이스 : 오직 추상 메서드만 갖는 구조체
    internal interface IRemoteControl
    {
        public abstract void PowerOn();
        public abstract void PowerOff();

        // abstract 생략
        public void ChUp();
        public void ChDown();

        public void SoundUp();
        public void SoundDown();
    }
}
