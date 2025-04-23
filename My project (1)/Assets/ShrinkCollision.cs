using UnityEngine;

public class ShrinkCollision : MonoBehaviour
{
    public float shrinkFactor = 0.9f;
    public float minSize = 0.1f; // Prevents disappearing

    void OnCollisionEnter(Collision collision)
    {
        if (transform.localScale.x > minSize &&
            transform.localScale.y > minSize &&
            transform.localScale.z > minSize)
        {
            transform.localScale *= shrinkFactor;
        }
        else
        {
            Debug.Log(gameObject.name + " is too small to shrink further!");
        }
    }
}
