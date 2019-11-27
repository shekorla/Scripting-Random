using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value=1f;
    public float minValue = 0;
    public float maxValue = 1f;

    public void UpdateValue (float amount)
    {
        value += amount;
    }

    public void resetValue()
    {
        value = 1f;
    }

    public void UpdateValueRange (float ammount)
    {
        if (value<= maxValue)
        {
            UpdateValue(ammount);
        }
        else
        {
            value = maxValue;
        }

        if (value>= minValue)
        {
            UpdateValue(ammount);
        }
        else
        {
            value = minValue;
        }
    }
}
