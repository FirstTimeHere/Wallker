using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.Cartridge
{
    public interface IMovement
    {
        public Vector3 GetNextPoint();
    }
}
