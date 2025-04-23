using UnityEngine;

public class SimpleCharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private CharacterController controller;
    private Transform thisTransform;
    private Vector3 movementVector = Vector3.zero;

    private void Start()
    {
        // Cache reference to components
        controller = GetComponent<CharacterController>();
        thisTransform = transform;

        // Check if CharacterController is missing
        if (controller == null)
        {
            Debug.LogError("CharacterController is missing! Please add one to this GameObject.", gameObject);
        }
    }

    private void Update()
    {
        MoveCharacter();
        KeepCharacterOnXAxis();
    }

    private void MoveCharacter()
    {
        if (controller == null) return; // Prevent errors if CharacterController is missing

        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0, moveY) * moveSpeed * Time.deltaTime;
        controller.Move(move);
    }

    private void KeepCharacterOnXAxis()
    {
        Vector3 currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}
