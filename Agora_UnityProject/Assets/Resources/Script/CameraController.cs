using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject _firstPersonCam;

    [SerializeField] private GameObject _thirdPersonCam;

    [SerializeField] private KeyCode _switchCamKey;

    private void Update()
    {
        if (Input.GetKeyDown(_switchCamKey))
        {
            SwitchCameraMode();
        }
    }

    private void SwitchCameraMode()
    {
        if (_firstPersonCam.activeSelf == true)
        {
            _firstPersonCam.SetActive(false);
            _thirdPersonCam.SetActive(true);
        }
        else
        {
            _firstPersonCam.SetActive(true);
            _thirdPersonCam.SetActive(false);
        }
    }
}
