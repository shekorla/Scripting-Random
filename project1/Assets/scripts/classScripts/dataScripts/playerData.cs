using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class playerData : gameArtData
{
    public UnityAction<GameObject> instanceAction;
    public UnityEvent onRunEve;
    
    public FloatData health;
    public List<weaponData> weapons;
    public clothesData shirt, pants;

    public void InstancePlayer()
    {
       var newPlayer= Instantiate(prefab);
       var playerSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
       playerSprite.sprite = sprite;
       playerSprite.color = spriteColor;
       instanceAction(newPlayer);
    }

    public void Run()
    {
        onRunEve.Invoke();
    }
}
