using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCrate : MonoBehaviour
{
    public void PickUpItem(GameObject item)
    {
        if (item.transform.parent != transform)
            item.transform.SetParent(transform);
        else
            DropItem(item);
    }

    public void DropItem(GameObject item)
    {
        item.transform.parent = null;
    }
}
