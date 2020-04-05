using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Android;
using UnityEngine.InputSystem.Users;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using InputDevice = UnityEngine.InputSystem.InputDevice;

[ExecuteInEditMode]
public class InputHandler : MonoBehaviour
{
    public PlayerInput playerInput;
    private void Awake()
    {
    }

    public void Update()
    {
        // Debug.Log(playerInput.user.actions);
        // Debug.Log(playerInput.user.controlScheme);
    }

    public void Interact(InputAction.CallbackContext context)
    {
        //
    }

    public void Look(InputAction.CallbackContext context)
    {
        //   
    }
    
    public void Jump(InputAction.CallbackContext context)
    {
        //   
    }
    
    public void Crouch(InputAction.CallbackContext context)
    {
        //   
    }
    
    public void PrimaryOffensiveAbility(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("PrimaryOffensiveAbility");
        }
    }
    
    public void SecondaryOffensiveAbility(InputAction.CallbackContext context)
    {
        //   
    }
    
    public void PrimaryDefensiveAbility(InputAction.CallbackContext context)
    {
        //   
    }    
    public void SecondaryDefensiveAbility(InputAction.CallbackContext context)
    {
        //   
    }
    public void UtilityAbility(InputAction.CallbackContext context)
    {
        //   
    }
    public void ToggleMatchInformationOverlayWindow(InputAction.CallbackContext context)
    {
        //   
    }
    public void PauseMenu(InputAction.CallbackContext context)
    {
        //   
    }
    public void Run(InputAction.CallbackContext context)
    {
        //   
    }    
    public void ChatInput(InputAction.CallbackContext context)
    {
        //   
    }
}