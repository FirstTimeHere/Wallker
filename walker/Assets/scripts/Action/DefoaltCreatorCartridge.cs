using Assets.scripts.Cartridge;
using System.Collections;
using UnityEngine;

namespace Assets.scripts.Action
{
    public class DefoaltCreatorCartridge : ICreatorCartridge
    {
        private readonly GameObject _prefab;
        private readonly Transform _parent;

        public DefoaltCreatorCartridge(GameObject prefab, Transform parent)
        {
            _prefab = prefab;
            _parent = parent;
        }

        ICartridge ICreatorCartridge.Create(Vector3 position)
        {
            GameObject cartridge = Object.Instantiate(_prefab, position, Quaternion.identity);
            cartridge.transform.SetParent(_parent);
            return cartridge.GetComponent<ICartridge>();
        }
    }
}