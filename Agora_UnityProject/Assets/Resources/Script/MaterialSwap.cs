using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwap : MonoBehaviour
{
    [SerializeField] private Material[] _material;

    private Renderer _renderer;
    private int _i;
    private bool canInteract;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.enabled = true;
        _renderer.sharedMaterial = _material[0];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canInteract = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canInteract)
            SetNextMaterial();
    }

    private void SetNextMaterial()
    {
        _i++;
        if (_i >= _material.Length)
            _i = 0;
        _renderer.sharedMaterial = _material[_i];
    }
}
