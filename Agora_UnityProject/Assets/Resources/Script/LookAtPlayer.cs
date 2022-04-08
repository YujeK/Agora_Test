using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : LookAt
{
    // Start is called before the first frame update
    void Start()
    {
        _target = FindObjectOfType<CharacterController>().transform;
    }
}
