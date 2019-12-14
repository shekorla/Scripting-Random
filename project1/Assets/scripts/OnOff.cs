using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class OnOff : MonoBehaviour
{
    public UnityEvent next, back;
    public bool upDown; //up is true down is false
   
    private float seconds=1f;
    private MeshRenderer mesh;
    private WaitForSeconds WFS;
    private Collider floor;
    private float i;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        floor = gameObject.GetComponent<Collider>();
        upDown = true;
        WFS=new WaitForSeconds(seconds);
        i = seconds;
    }

    public void Swap()
    {
        if (upDown==true)
        {
            next.Invoke();
            upDown = false;
            StartCoroutine(Hold());
        }
        else
        {
            back.Invoke();
            upDown = true;
            StartCoroutine(Hold());
        }
    }
     IEnumerator Hold()
     { 
         mesh.enabled = true;
        floor.isTrigger = false;
        while (i>0)
        {
            i--;
            yield return WFS;
        }
        i = seconds;
        mesh.enabled = false;
        floor.isTrigger = true;
    }
}
