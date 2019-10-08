using UnityEngine;
[CreateAssetMenu]
public class playerData : gameArtData
{
    public weaponData weapon;

    public void InstancePlayer()
    {
       var newPlayer= Instantiate(prefab);
       var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
       newSprite.sprite = sprite;
       newSprite.color = color;
    }
}
