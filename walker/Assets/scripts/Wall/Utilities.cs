using Assets.scripts.Cartridge;
using System.Collections;
using UnityEngine;

namespace Assets.scripts.Wall
{
    public static class Utilities
    {
        public static ICartridge GetCartridge(GameObject obj)
        {
            return obj.GetComponent<ICartridge>();
        }
    }
}