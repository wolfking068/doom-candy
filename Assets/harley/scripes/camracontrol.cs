﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure;

public class camracontrol : MonoBehaviour {
    public Rigidbody playerBody;
    public float mouseSensitivity_x;
    public float mouseSensitivity_y;
    public float mouseSensitivity_x2;
    public float mouseSensitivity_y2;
    public controller controller;
    float xAxisClamp = 0.0f;

    private void Update()
    {
        if(gamemaniger.GM.pose== true)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
 
            return;
        }
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if (gamemaniger.GM.keybordcontrols == true)
        {

            RotateCamera();
        }
        if (gamemaniger.GM.keybordcontrols == false)
        {
            RotatecCameracomntroler();
        }
    }
    void RotateCamera()
    {

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        float rotAmountX = mouseX * mouseSensitivity_x2;
        float rotAmountY = mouseY * mouseSensitivity_y2;

        xAxisClamp -= rotAmountY;

        Vector3 targetRotCam = transform.rotation.eulerAngles;
        Vector3 targetRotBody = playerBody.transform.rotation.eulerAngles;

        targetRotCam.x -= rotAmountY;
        targetRotCam.z = 0;
        targetRotCam.y += rotAmountX;

        if (xAxisClamp > 90)
        {
            xAxisClamp = 90;
            targetRotCam.x = 90;
        }
        else if (xAxisClamp < -90)
        {
            xAxisClamp = -90;
            targetRotCam.x = 270;
        }

        print(mouseY);


        transform.rotation = Quaternion.Euler(targetRotCam);
        playerBody.rotation = Quaternion.Euler(targetRotBody);
    }
    void RotatecCameracomntroler()
    {

        float mouseX = controller.horizontalcamra;
        float mouseY = controller.verticalcamra;

        float rotAmountX = mouseX * mouseSensitivity_x;
        float rotAmountY = mouseY * mouseSensitivity_y;

        xAxisClamp -= rotAmountY;

        Vector3 targetRotCam = transform.rotation.eulerAngles;
        Vector3 targetRotBody = playerBody.transform.rotation.eulerAngles;

        targetRotCam.x -= rotAmountY;
        targetRotCam.z = 0;
        targetRotCam.y += rotAmountX;

        if (xAxisClamp > 90)
        {
            xAxisClamp = 90;
            targetRotCam.x = 90;
        }
        else if (xAxisClamp < -90)
        {
            xAxisClamp = -90;
            targetRotCam.x = 270;
        }

        //print(mouseY);


        transform.rotation = Quaternion.Euler(targetRotCam);
        playerBody.rotation = Quaternion.Euler(targetRotBody);
    }
}
