using UnityEngine;
[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;

    public void updateValue(Vector3 newData)
    {
        value = newData;
    }
    
}
