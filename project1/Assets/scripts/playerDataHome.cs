using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class playerDataHome : ScriptableObject
{
    public GameObject prefab;
    public string nameVar;
    public float intel, charis, luck, stre, wis, speed;
    public Color pColor;
    public Sprite pSprite;
    public float xOffset;
}
