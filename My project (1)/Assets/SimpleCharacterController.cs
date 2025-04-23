using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float sprintSpeed = 8f;
    public float jumpForce = 3f;
    public float gravity = -15f;

    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;

    public UnityEvent triggerEvent;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        Stamina();              // Check for sprinting
        MoveCharacter();        // Handle movement + jumping
        ApplyGravity();         // Simulate gravity
        KeepCharacterOnXAxis(); // Stay on 2D plane (optional)
    }

    private void MoveCharacter()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);

        if (Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
    }

    private void ApplyGravity()
    { 
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else if (velocity.y < 0)
        {
            velocity.y = -2f; // helps stick to ground
        }

        controller.Move(velocity * Time.deltaTime);
    }

    private void KeepCharacterOnXAxis()
    {
        Vector3 currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }

    private void Stamina()
    {
        if (Input.GetKey(KeyCode.S))
        {
            moveSpeed = sprintSpeed;
            triggerEvent.Invoke();
        }
        else
        {
            moveSpeed = 5f;
        }
    }
}
