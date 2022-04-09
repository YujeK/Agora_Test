using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField]
    private Transform _dest;

    private bool _picked;

    private CharacterMovement _characterMovement;

    private void Start()
    {
        _characterMovement = FindObjectOfType<CharacterMovement>();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && GetComponent<Interactable>().canInteract)
        {
            if (!_picked && !_characterMovement._pickingUp)
                Pick();
            else if (_picked)
                Drop();
        }

        if (_picked)
            transform.position = _dest.position;
    }
    public void Pick()
    {
        _characterMovement._pickingUp = true;
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        transform.position = _dest.position;
        transform.SetParent(_dest.transform.parent);
        _picked = true;
    }

    public void Drop()
    {
        _characterMovement._pickingUp = false;
        GetComponent<Rigidbody>().useGravity = true;
        transform.parent = null;
        _picked = false;
    }
}