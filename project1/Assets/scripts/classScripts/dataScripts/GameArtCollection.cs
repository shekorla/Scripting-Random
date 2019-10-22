using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<gameArtData> collectionList;

    public void AddData(gameArtData obj)
    {
        collectionList.Add(obj);
    }
}
