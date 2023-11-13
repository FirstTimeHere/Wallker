using Assets.scripts.Action;
using Assets.scripts.Cartridge;
using System.Collections;
using UnityEngine;

namespace Assets.scripts.Weapon
{
    public class WeaponControl : MonoBehaviour
    {
        [SerializeField] private GameObject _prefab;
        [SerializeField] private Transform _parent;
        [SerializeField] private Transform _spawnCartidge;
        [SerializeField, Range(0f, 1000f)] private float _speed;

        private Transform _thisTransform; //ключевое слово this?

        private void Start()
        {
            _thisTransform = transform;
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }

        private void Shoot()
        {
            CalculatorDirection calculatorDirection = new CalculatorDirection(_thisTransform, _spawnCartidge);
            Vector3 direction = calculatorDirection.GetDIrection();

            IMovement movement = new CalculatorMovementByDirection(direction, _speed);
            ICreatorCartridge creator = new DefoaltCreatorCartridge(_prefab, _parent);
            Shooting shooting = new Shooting(movement, creator);
            shooting.Shoot(_spawnCartidge.position);
        }
    }
}