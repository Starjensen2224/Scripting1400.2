using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color newColor = Color.red;

    void OnCollisionEnter(Collision collision)
    {
        // Change the object's color when hit
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null && renderer.material != null)
        {
            renderer.material.color = newColor;
        }
        else
        {
            Debug.LogError("Renderer or material not found on " + gameObject.name);
        }
    }
}
