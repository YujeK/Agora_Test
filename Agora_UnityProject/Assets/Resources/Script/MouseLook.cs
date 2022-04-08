using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] private Transform _characterModel;

    [Header(("Mouse Settings"))]
    [SerializeField] private float _mouseSensitivity = 100f;
    [SerializeField] private bool _lockCursor;

    [SerializeField] private float _minYangle = -90f;
    [SerializeField] private float _maxYangle = 90f;


    private float _xRotation = 0f;

    private void Start()
    {
        SetCursor();
    }

    // Set the Mouse Cursor State
    private void SetCursor()
    {
        if (_lockCursor)
            Cursor.lockState = CursorLockMode.Locked;
    }

    // Rotate the Camera and the character based on Mouse Inputs
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity * Time.deltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, _minYangle, _maxYangle);

        transform.localRotation = Quaternion.Euler(_xRotation, 0f, 0f);
        _characterModel.Rotate(Vector3.up * mouseX);
    }
}
