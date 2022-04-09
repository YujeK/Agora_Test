using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StairsRiddle : MonoBehaviour
{
    [SerializeField] private GameObject[] stairs;

    public void Start()
    {
        stairs[0].transform.DOMoveY(5, 5);
    }
}