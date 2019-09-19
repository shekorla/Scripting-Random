using System;
using UnityEngine;
using UnityEngine.Events;

public class bullet : MonoBehaviour
{
    private float floatValue = 100, timer = 100;
    public GameObject enemy;

    private void Start()
    {
        if (gameObject.name != "bullet")
        {
            Vector3 enemyLoc=new Vector3(enemy.transform.position.x,enemy.transform.position.y,0);
            gameObject.transform.LookAt(enemyLoc);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("hi");
        if (other.name=="Enemy")
        {
            Destroy(gameObject);
            print("KaPow!");
        }
    }

    private void Update()
    {
        if (gameObject.name != "bullet")// if my name is bullet clone
        {
            gameObject.transform.position += 10*Time.deltaTime*transform.forward;
            if (timer > 0)
            {
                timer += -1;
            }
            else
            {
                timer = floatValue;
                //print("Sploosh!");
                Destroy(gameObject);
            }
        }
    }
}
