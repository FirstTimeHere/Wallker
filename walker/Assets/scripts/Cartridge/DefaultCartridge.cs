using Assets.scripts.Cartridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class DefaultCartridge : MonoBehaviour, ICartridge
{
    private Transform _thisTransform;
    private void Awake()
    {
        _thisTransform = transform;
    }

    void ICartridge.DestroyYourself()
    {
        Destroy(gameObject);
    }

    private IEnumerator Run(IMovement movement)
    {
        while (true)
        {
            Vector3 point = movement.GetNextPoint();
            _thisTransform.Translate(point);
            yield return null;
        }
    }

    void ICartridge.ToRun(IMovement movement)
    {
        StartCoroutine(Run(movement));
    }
}

