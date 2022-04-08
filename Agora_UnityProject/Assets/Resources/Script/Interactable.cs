using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{
    private bool canInteract;

    public UnityEvent OnInteractEvent;

    public UnityEvent OnEnterEvent;
    public UnityEvent OnExitEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && canInteract)
            OnInteract();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnEnter();
            canInteract = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OnExit();
            canInteract = false;
        }
    }

    private void OnInteract()
    {
        OnInteractEvent.Invoke();
    }

    private void OnExit()
    {
        OnExitEvent.Invoke();
    }

    private void OnEnter()
    {
        OnEnterEvent.Invoke();
    }
}
