using UnityEngine;

public class fireWeapon : MonoBehaviour
{
    public applyForce ammo;
    //public playerData dontHitMe;
    
    public void fire()
    {
        if (Input.GetButtonDown("Fire1"))//fire 1 is your left mouse
        {
            Instantiate(ammo,transform.position,Quaternion.identity);
        } 
    }
}
//notes about the final because this file is open: side scroller, if, esle, foreach, so basically make the sidescroller
//nice enough to present.
//class went over, to catch up use game action/handler to make them generic, and make firing work