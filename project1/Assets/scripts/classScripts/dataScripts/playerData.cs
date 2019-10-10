using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class playerData : gameArtData
{
    public FloatData health;
    public List<weaponData> weapons;
    public clothesData shirt, pants;

    public void InstancePlayer()
    {
       var newPlayer= Instantiate(prefab);
       var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
       newSprite.sprite = sprite;
       newSprite.color = spriteColor;
    }
}
