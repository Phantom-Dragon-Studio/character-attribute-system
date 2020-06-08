using System;
using System.Collections;
using System.Collections.Generic;
using PhantomDragonStudio.Tools;
using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement_CC : MonoBehaviour
{
    [SerializeField] private float speed = 12f;
    [SerializeField] private float gravity = -9.81f;
    [SerializeField] private float jumpHeight = 3f;
    [SerializeField] private float groundDistance = 0.1f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private CharacterController characterController;
    
    [SerializeField] [ShowOnly] bool isGrounded;
    [SerializeField] [ShowOnly] private Vector3 velocity;
    [SerializeField] [ShowOnly] private float horizontal;
    [SerializeField] [ShowOnly] private float vertical;
    private void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
    
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        characterController.Move(move * (speed * Time.deltaTime)); //Handle latitude and longitude movements.
        velocity.y += gravity * Time.deltaTime;
        characterController.Move(velocity * Time.deltaTime); //Handle Vertical Movements.
    }
    
    private void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
    }
    
    public void ReadMovementInput(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;
    }

    public void ReadJumpInput(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        if(isGrounded)
            Jump();
    }
}
