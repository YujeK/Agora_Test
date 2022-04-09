using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    private Transform _dest;

    private bool _picked;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && GetComponent<Interactable>().canInteract)
        {
            if (!_picked)
                Pick();
            else
                Drop();
        }
    }
    public void Pick()
    {
        GetComponent<Rigidbody>().useGravity = false;
        transform.position = _dest.position;
        transform.SetParent(_dest.transform.parent);
        _picked = true;
    }

    public void Drop()
    {
        transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        _picked = false;
    }
}