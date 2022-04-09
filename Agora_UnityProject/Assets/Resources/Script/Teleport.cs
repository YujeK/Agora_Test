using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public void TeleportTargetToLocation(Transform target)
    {
        target.transform.position = transform.position;
    }
}
