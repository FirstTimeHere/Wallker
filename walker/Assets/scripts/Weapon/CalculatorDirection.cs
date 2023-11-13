using System.Collections;
using UnityEngine;

namespace Assets.scripts.Weapon
{
    public class CalculatorDirection
    {
        private readonly Transform _weapon;
        private readonly Transform _spawnCartridge;

        public CalculatorDirection(Transform weapon, Transform spawnCatridge)
        {
            _weapon = weapon;
            _spawnCartridge = spawnCatridge;
        }

        public Vector3 GetDIrection()
        {
            Vector3 b=_spawnCartridge.position;
            Vector3 a = _weapon.TransformPoint(new Vector3(0, _spawnCartridge.localPosition.y, 0));
            return b - a;
        }
    }
}