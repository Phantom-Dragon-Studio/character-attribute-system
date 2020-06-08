using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformParenter : MonoBehaviour
{
    [SerializeField] private LayerMask mask;
    private FixedJoint joint;
    private void OnTriggerEnter(Collider other)
    {
        if ((mask & 1 << other.gameObject.layer) == 1 << other.gameObject.layer)
        {
            // Debug.Log("Collision enter triggered by " + other.gameObject.name);
            other.transform.SetParent(this.transform);
        }
    }

    private void Update()
    {
        if (this.transform.parent == null)
        {
            transform.DetachChildren();
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
    }
}
