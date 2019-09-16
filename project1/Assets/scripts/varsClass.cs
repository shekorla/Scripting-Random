using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class varsClass : MonoBehaviour
{
    public float floatValue = 80;
    public UnityEvent Event;

    private void Start()
    {
        gameObject.SetActive(true);
        gameObject.transform.LookAt(Input.mousePosition);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name!="Player")
        {
            Event.Invoke();
            print("KaPow!");
        }
        
    }

    private void Update()
    {
        if (gameObject.name != "bullet")
        {
            gameObject.transform.position += transform.forward;
            if (floatValue > 0)
            {
                floatValue += -1;
            }
            else
            {
                Event.Invoke();
                floatValue = 80;
                print("Sploosh!");
            }
        }
    }
}
