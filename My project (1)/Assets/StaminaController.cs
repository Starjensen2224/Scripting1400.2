using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/StaminaFloatData")]
public class StaminaController : ScriptableObject
{
    public float value;

    public void Increase(float amount)
    {
        value += amount;
    }

    public void Decrease(float amount)
    {
        value -= amount;
    }
}
