using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<gameArtData> collectionList;

    public void AddData(gameArtData obj)
    {
        if (!collectionList.Contains(obj))
        {
            collectionList.Add(obj);
        }
    }

    public void RemoveLastItem()
    {
        collectionList.RemoveAt(collectionList.Count-1);
    }
}
