using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : Player
{

    [SerializeField] private float speed;

    [SerializeField] private Transform transform; //cam

    private void Update()
    {
        Grounded();
    }

    private void FixedUpdate()
    {
        Move(transform, speed);
    }
}
