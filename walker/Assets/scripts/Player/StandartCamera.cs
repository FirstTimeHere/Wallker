using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandartCamera : MonoBehaviour
{
    private float xRotation;
    private float yRotation;
    protected void CameraRotation(float sensX, float sensY, Transform orientation)
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;



        sensX = Input.GetAxis("Mouse X") * Time.deltaTime * sensX;
        sensY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensY;

        xRotation -= sensY;
        yRotation += sensX;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
