using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentWeapon : MonoBehaviour
{
    public SpriteRenderer prenderer;
    public void changeImage(weaponData weapSprite)
    {
        prenderer.sprite = weapSprite.sprite;
        prenderer.color = weapSprite.spriteColor;
    }
}
