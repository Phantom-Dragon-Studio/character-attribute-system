using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.Universal;

public class Rotation : MonoBehaviour
{
    [SerializeField] private Transform playerBody;
    [SerializeField] private Transform cameraTransform;
    [Range(0f, 25)] public float horizontalSensitivity;
    [Range(0f, 25f)] public float verticalSensitivity;

    private float xRotation;
    private float mouseX;
    private float mouseY;
    private Mouse cursor;

    private void Awake()
    {
        cursor = Mouse.current;
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    public void Rotate(InputAction.CallbackContext context)
    {
        mouseX = context.ReadValue<Vector2>().x * horizontalSensitivity * Time.deltaTime;
        mouseY = context.ReadValue<Vector2>().y * verticalSensitivity  * Time.deltaTime;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
    }

    public void Update()
    {
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}