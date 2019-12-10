using System;
using UnityEngine;

public class fireWeapon : MonoBehaviour
{
    public applyForce ammo;
    public GameObject startSpot;
    

    public void fire()
         {
             if (Input.GetButtonDown("Fire1"))//fire 1 is your left mouse
             {
                 Instantiate(ammo,startSpot.transform.position,Quaternion.identity);
             } 
         }
    public void RapidFire()
    {
        Instantiate(ammo, startSpot.transform.position, Quaternion.identity);
        Debug.Log(startSpot.transform.position);
    }
}
