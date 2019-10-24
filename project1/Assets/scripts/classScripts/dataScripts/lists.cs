using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class lists : ScriptableObject
{
    public List<string> stringList;
    public List<int> intList;
    public List<float> floatList;

    public List<GameObject> gameObjectList;
    public List<FloatData> floatDataList;
}
