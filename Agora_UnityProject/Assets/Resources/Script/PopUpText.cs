using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PopUpText : MonoBehaviour
{
    [SerializeField] private TextMeshPro _popUpText;

    public void EnablePopUp()
    {
        _popUpText.gameObject.SetActive(true);
    }
    public void DisablePopUp()
    {
        _popUpText.gameObject.SetActive(false);
    }
}