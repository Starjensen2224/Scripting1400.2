using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb != null) // Ensure there's a Rigidbody before applying force
        {
            rb.AddForce(Vector3.right * 500);
        }
        else
        {
            Debug.LogError("Rigidbody not found on " + gameObject.name);
        }
    }
}
