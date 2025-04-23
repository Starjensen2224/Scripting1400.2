using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    // Event function
    private void Start()
    {
        // Cache the Animator component attached to CharacterArt
        animator = GetComponent<Animator>();
    }

    // Event function
    private void Update()
    {
        HandleAnimations();
    }

    // Frequently called
    private void HandleAnimations()
    {
        // Handle running and idling
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        // Handle jumping
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }

        // Handle wall jumping
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump");
        }
    }
}
