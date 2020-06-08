using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Rotate : MonoBehaviour
{
    [SerializeField] private float sensitivity = 50f;
    [SerializeField] private float sensMultiplier = 1f;
    [SerializeField] private Transform playerCamera;
    [SerializeField] private Transform orientation;

    public bool locked = false;
    
    private float desiredX;
    private float xRotation;
    
    public void Look(InputAction.CallbackContext context) 
    {
        if(locked) return;
        
        float mouseX = context.ReadValue<Vector2>().x * sensitivity * Time.fixedDeltaTime * sensMultiplier;
        float mouseY = context.ReadValue<Vector2>().y * sensitivity * Time.fixedDeltaTime * sensMultiplier;

        //Find current look rotation
        Vector3 rot = playerCamera.transform.localRotation.eulerAngles;
        desiredX = rot.y + mouseX;
        
        //Rotate, and also make sure we dont over- or under-rotate.
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Perform the rotations
        playerCamera.transform.localRotation = Quaternion.Euler(xRotation, desiredX, 0);
        orientation.transform.localRotation = Quaternion.Euler(0, desiredX, 0);
    }
}
