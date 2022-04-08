using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialSwap : MonoBehaviour
{
    [SerializeField] private Material[] _material;

    private Renderer _renderer;
    private int _i;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.enabled = true;
        _renderer.sharedMaterial = _material[0];
    }

    public void SetNextMaterial()
    {
        _i++;
        if (_i >= _material.Length)
            _i = 0;
        _renderer.sharedMaterial = _material[_i];
    }
}
