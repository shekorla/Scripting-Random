using UnityEngine;
[CreateAssetMenu]
public class intData : ScriptableObject
{
    public int value = 1;

    public void updateValue(int number)
    {
        value += number;
    }

    public void resetValue()
    {
        value = 0;
    }

    public void setValue(int newNumb)
    {
        value = newNumb;
    }
}
