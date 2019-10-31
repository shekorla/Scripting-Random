using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandle : MonoBehaviour
{
    public weaponData weapon;

    public void SwitchWeapon(weaponData newWeapon)
    {
        weapon = newWeapon;
    }
    
}
