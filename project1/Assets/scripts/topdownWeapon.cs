using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class topdownWeapon : MonoBehaviour
{
    public GameObject player;
    public int rotTimeReset;
    public bool direction;//left is true, right is false
    public UnityEvent callSpinEve, spinStartEve,spinStopEve;
    public SpriteRenderer selfSpr;

    private WaitForSeconds wfsObj;
    private int spinLeft, spinRight, rotTime;
    private Vector3 plrLoc;
    private bool dontCrash;

    private void Start()
    {
        wfsObj = new WaitForSeconds(.01f);
        spinLeft = -10;
        spinRight = 10;
        rotTime = rotTimeReset;
        direction = true;
        dontCrash = false;
    }

    public void Update()
    {
        plrLoc = player.transform.position;
        if (Input.GetButtonDown("Jump"))
        {
            callSpinEve.Invoke();
        }
    }

    public void CallSpin()
    {
        StartCoroutine(Spin());
    }
    public IEnumerator Spin()
    {
        if (dontCrash==false)
        {
            selfSpr.color=Color.red;
            spinStartEve.Invoke();
            dontCrash = true;
            direction = true;
            rotTime = rotTimeReset;
            while (rotTime>0)
            {
                if (direction==true)
                {
                    transform.RotateAround(plrLoc, Vector3.up, spinLeft);
                    rotTime--;
                    yield return wfsObj;
                }
            }
            rotTime = rotTimeReset;
            direction = false;
            while (rotTime>0)
            {
                if (direction==false)
                {
                    transform.RotateAround(plrLoc, Vector3.up, spinRight);
                    rotTime--;
                    yield return wfsObj;
                }
            }
            direction=true;
            dontCrash = false;
            spinStopEve.Invoke();
            selfSpr.color=Color.white;
        }
    }
}