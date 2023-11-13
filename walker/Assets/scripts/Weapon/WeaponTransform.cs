using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponTransform : MonoBehaviour
{
    [SerializeField] private Transform camWeaponTransform;
    private void FixedUpdate()
    {
        transform.position = camWeaponTransform.position;
    }
}
