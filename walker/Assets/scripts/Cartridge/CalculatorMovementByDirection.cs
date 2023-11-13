using System.Collections;
using UnityEngine;

namespace Assets.scripts.Cartridge
{
    public class CalculatorMovementByDirection : IMovement
    {
        private readonly Vector3 _direction; //мб через свойства?
        private readonly float _speed;

        public CalculatorMovementByDirection(Vector3 direction, float speed)
        {
            _direction = direction;
            _speed = speed;
        }

        public Vector3 GetNextPoint()
        {
            return _direction * Time.deltaTime * _speed;
        }
    }
}