using UnityEngine;
using UnityEngine.UI;

public class SimpleImageBehavior : MonoBehaviour
{
    public SimpleFloatData dataObject;
    private Image imageObject;

    private void Start()
    {
        imageObject = GetComponent<Image>();

        if (imageObject == null)
        {
            Debug.LogWarning("Image component not found on " + gameObject.name);
        }

        if (dataObject == null)
        {
            Debug.LogWarning("No dataObject assigned to " + gameObject.name);
        }
    }

    private void Update()
    {
        UpdateWithFloatData();
    }

    public void UpdateWithFloatData()
    {
        imageObject.fillAmount = Mathf.Clamp01(dataObject.value);
    }
    public void ResetBar()
    {
        if (dataObject != null)
        {
            dataObject.value = 1f;
            UpdateWithFloatData(); // optional, if you want instant visual feedback
        }
    }

}
