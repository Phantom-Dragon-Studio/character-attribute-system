using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    //Variables
    [Range(0f, 100f)] public float speed;
    [Range(0f, 100f)] public float jumpHeight;
    [SerializeField]private float gravity = -9.81f; 
    [SerializeField] private CharacterController controller;
    [SerializeField] private Transform groundCheck;

    public float groundDistance;
    public LayerMask groundMask;

    private Vector3 moveDirection, velocity;
    private bool isGrounded = true;
    public bool IsGrounded => isGrounded;

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

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0f)
        {
            velocity.y = -2f;
        }
        controller.Move((transform.right * moveDirection.x + transform.forward * moveDirection.z) * speed / 1000);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}