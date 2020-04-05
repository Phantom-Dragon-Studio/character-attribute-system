using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleMouseLock : MonoBehaviour
{
    private bool locked = true;
    private Rotation rotationMechanics;
    
    private void Awake()
    {
        rotationMechanics = GetComponent<Rotation>();
    }

    public void ToggleLock(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        locked = !locked;
        rotationMechanics.enabled = locked;
        Cursor.lockState = locked ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !locked;
    }
}
