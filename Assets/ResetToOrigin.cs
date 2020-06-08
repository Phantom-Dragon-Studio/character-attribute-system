using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToOrigin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = Vector3.zero + Vector3.up * 5;
    }
}
