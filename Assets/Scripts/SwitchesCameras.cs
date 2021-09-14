using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchesCameras : MonoBehaviour
{
    public Camera UPcamera, FPScamera, RIGHTcamera, LEFTcamera;

    void Awake()
    {
        FPScamera.enabled = true;
        UPcamera.enabled = false;
        RIGHTcamera.enabled = false;
        LEFTcamera.enabled = false;
    }

    void Update()
    {
        switcheCamera();
    }

    void switcheCamera()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            UPcamera.enabled = true;
            FPScamera.enabled = false;
            RIGHTcamera.enabled = false;
            LEFTcamera.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FPScamera.enabled = true;
            UPcamera.enabled = false;
            RIGHTcamera.enabled = false;
            LEFTcamera.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            RIGHTcamera.enabled = true;
            UPcamera.enabled = false;
            FPScamera.enabled = false;
            LEFTcamera.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            LEFTcamera.enabled = true;
            UPcamera.enabled = false;
            FPScamera.enabled = false;
            RIGHTcamera.enabled = false;
        }
    }
}
