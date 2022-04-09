using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    private Vector3 _targetPosition;
    [SerializeField] private bool _isTextBubble;

    [SerializeField] protected Transform _target;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        _targetPosition = new Vector3(_target.position.x, transform.position.y, _target.position.z);
        if (_isTextBubble)
            transform.rotation = Quaternion.LookRotation(transform.position - _targetPosition);
        else
            transform.LookAt(_targetPosition);
    }
}