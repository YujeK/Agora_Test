using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class StairsRiddle : MonoBehaviour
{
    int _i;
    [SerializeField] private GameObject[] _stairs;

    private float[] _startValue;

    private void Start()
    {
        _startValue = new float[_stairs.Length];
        InitStartValue();
    }

    private void InitStartValue()
    {
        for (int i = 0; i < _stairs.Length; i++)
        {
            _startValue[i] = _stairs[i].transform.position.y;
        }
    }

    public void TriggerStair(int id, float endValue, float duration)
    {
        _stairs[id].transform.DOMoveY(endValue, duration);
    }

    public void UnTriggerStair(int id, float duration)
    {
        _stairs[id].transform.DOMoveY(_startValue[id], duration);
    }
}