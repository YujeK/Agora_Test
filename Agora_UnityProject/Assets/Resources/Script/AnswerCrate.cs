using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnswerCrate : MonoBehaviour
{
    [SerializeField] private int _answer = -1;
    private StairsRiddle _stairsRiddle;

    [SerializeField] private float _duration;

    [SerializeField] private float _endValue;

    private void Start()
    {
        _stairsRiddle = GetComponentInParent<StairsRiddle>();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MagicCrate")
        {
            _stairsRiddle.UnTriggerStair(_answer, _duration);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MagicCrate")
        {
            if (other.GetComponent<MaterialSwap>()._materialID == _answer)
                _stairsRiddle.TriggerStair(_answer, _endValue, _duration);
        }
    }
}