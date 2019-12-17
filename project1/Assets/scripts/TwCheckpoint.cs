using System;
using UnityEngine;
using UnityEngine.Events;

public class TwCheckpoint : MonoBehaviour
{
    public UnityEvent dead;
    public CharacterController cont;
    public Vector3 currentCK;
    public Vector3Data startPoint;
    public FloatData health;

    private void Start()
    {
        currentCK = startPoint.value;
    }

    public void YouDied()
    {
        print("dead");
        cont.enabled = false;
        gameObject.transform.position=currentCK;
        cont.enabled = true;
        dead.Invoke();
    }

    public void UpdateCK(Vector3Data newLoc)
    {
        currentCK = newLoc.value;
        print(currentCK);
    }

    private void Update()
    {
        if (health.value<=0)
        {
            YouDied();
            health.value = 1f;
        }
    }
}
