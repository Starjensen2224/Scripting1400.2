using UnityEngine;

public class Bounce : MonoBehaviour
{
    public float bounceForce = 3f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (rb == null)
        {
            Debug.LogError("No Rigidbody found on " + gameObject.name);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (rb != null)
        {
            rb.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        }
    }
}
