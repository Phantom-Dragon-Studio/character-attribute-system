using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleMouseLock : MonoBehaviour
{
    private bool locked = false;
    [SerializeField] private Player_Rotate rotationMechanics;
    
    private void Awake()
    {
        rotationMechanics = GetComponent<Player_Rotate>();
    }

    public void ToggleLock(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        locked = !locked;
        rotationMechanics.locked = locked;
        Cursor.lockState = locked ? CursorLockMode.Locked : CursorLockMode.None;
    }
}
