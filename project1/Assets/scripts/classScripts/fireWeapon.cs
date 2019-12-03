using UnityEngine;

public class fireWeapon : MonoBehaviour
{
    public applyForce ammo;
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))//fire 1 is your left mouse
        {
            Instantiate(ammo,transform.position,Quaternion.identity);
        } 
    }
}
