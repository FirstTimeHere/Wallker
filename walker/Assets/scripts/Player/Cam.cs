using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    [SerializeField] private Transform camTransform;

    private void Update()
    {
        transform.position = camTransform.position;
    }

}
