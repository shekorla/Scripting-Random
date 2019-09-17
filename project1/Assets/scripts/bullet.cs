using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class bullet : MonoBehaviour
{
    private float floatValue = 50;
    private float timer = 50;
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
            Destroy(gameObject);
            print("KaPow!");
        }
    }

    private void Update()
    {
        if (gameObject.name != "bullet")// if my name is bullet clone
        {
            gameObject.transform.position += transform.forward*Time.deltaTime;
            if (timer > 0)
            {
                timer += -1;
            }
            else
            {
                timer = floatValue;
                print("Sploosh!");
                Destroy(gameObject);
            }
        }
    }
}
