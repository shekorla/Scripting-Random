using System;
using UnityEngine;
using UnityEngine.Events;

public class TwCheckpoint : MonoBehaviour
{
    public UnityEvent dead;
    public CharacterController cont;
    public Vector3Data checkPLoc;

    private void Start()
    {
        checkPLoc.value=new Vector3(-6,-3,0);
    }

    public void YouDied()
    {
        cont.enabled = false;
        gameObject.transform.position=checkPLoc.value;
        cont.enabled = true;
        dead.Invoke();
    }
}
