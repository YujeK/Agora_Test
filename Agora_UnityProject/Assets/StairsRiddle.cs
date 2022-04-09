using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StairsRiddle : MonoBehaviour
{
    int _i;
    [SerializeField] private GameObject[] stairs;

    public void TriggerStair(int id, float endValue, float duration)
    {
        stairs[id].transform.DOMoveY(endValue, duration);
    }
}