using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterLocomotion : MonoBehaviour
{
    //Variables
    [Range(0f, 100f)] public float speed;
    [Range(0f, 100f)] public float runSpeed;
    [Range(0f, 100f)] public float jumpHeight;
    [SerializeField]private float gravity = -9.81f; 
    [SerializeField] private CharacterController controller;
    [SerializeField] private Transform groundCheck;

    public float groundDistance;
    public LayerMask groundMask;

    private Vector3 moveDirection, velocity;
    private bool isGrounded = true;
    public bool IsGrounded => isGrounded;
    
    private bool isRunning = false;
    public bool IsRunning => isRunning;

    public void Move(InputAction.CallbackContext context)
    {
        moveDirection.x = context.ReadValue<Vector2>().x;
        moveDirection.z = context.ReadValue<Vector2>().y;
    }
    
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (isGrounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }
    }

    public void Run(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isRunning = !isRunning;
        }
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }

        if (isRunning)
        {
            controller.Move((transform.right * moveDirection.x + transform.forward * moveDirection.z) * runSpeed / 1000);
        }
        else
        {
            controller.Move((transform.right * moveDirection.x + transform.forward * moveDirection.z) * speed / 1000);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}