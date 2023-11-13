using Assets.scripts.Cartridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.Action
{
    public interface ICreatorCartridge
    {
        public ICartridge Create(Vector3 position);
    }
}
