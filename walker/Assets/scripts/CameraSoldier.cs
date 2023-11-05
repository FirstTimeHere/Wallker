using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSoldier : StandartCamera
{
    [SerializeField] private float sensX;
    [SerializeField] private float sensY;




    [SerializeField] private Transform orientation;


    private void Update()
    {
        CameraRotation(sensX, sensY, orientation);
    }
}
