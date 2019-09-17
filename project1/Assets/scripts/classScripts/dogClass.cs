using System;
using UnityEngine;
using UnityEngine.Events;

public class dogClass : MonoBehaviour
{
    public UnityEvent doesStuff;
    private void OnMouseDown()
    {
       doesStuff.Invoke();
    }
}
