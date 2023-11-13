using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.scripts.Cartridge
{
    public interface ICartridge
    {
        public void ToRun(IMovement movement);

        public void DestroyYourself();
    }
}
