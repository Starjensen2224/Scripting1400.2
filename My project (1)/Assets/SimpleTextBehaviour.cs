using System.Collections;
using System.Collections.Generic;
using TMPro;
using System.Globalization;
using UnityEngine;
[RequireComponent(typeof(TextMeshProUGUI))]
public class SimpleTextBehaviour : MonoBehaviour
{
    public SimpleIntData dataObject;
    private  TextMeshProUGUI textObject;
    private void Start()
    {
        textObject = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        UpdateWithIntData();
    }
    public void UpdateWithIntData()
    {
        textObject.text = "Score: " + dataObject.value.ToString(CultureInfo.InvariantCulture);
    }
}