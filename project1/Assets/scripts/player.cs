using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;
using Random = System.Random;

public class player : MonoBehaviour
{
    public float moveSpeed=1;//players move speed floats can be 5.5
    public int score = 0;
    private bool bump = false;
    private void Start()
    {
        transform.position = new Vector3(0, 0, 0);//start in the center each time
    }
    private void Update()
    {
        if (!bump)
        {
            if (Input.GetKey("up") || Input.GetKey("w"))
            {
                transform.position += new Vector3(+0, +moveSpeed, +0);
            }

            if (Input.GetKey("left") || Input.GetKey("a"))
            {
                transform.position += new Vector3(-moveSpeed, +0, +0);
            }

            if (Input.GetKey("right") || Input.GetKey("d"))
            {
                transform.position += new Vector3(+moveSpeed, +0, +0);
            }

            if (Input.GetKey("down") || Input.GetKey("s"))
            {
                transform.position += new Vector3(+0, -moveSpeed, +0);
            }
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name=="bwall"||other.gameObject.name=="twall"||other.gameObject.name=="lwall"||other.gameObject.name=="rwall")
        {
            moveSpeed=1;//move normal once you leave the wall
            bump = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.name=="bwall")
        {
            bump = true;
            transform.position += new Vector3(+0, +moveSpeed+moveSpeed, +0);
        }
        if (other.gameObject.name=="twall")
        {
            bump = true;
            transform.position += new Vector3(+0, -moveSpeed-moveSpeed, +0);
        }if (other.gameObject.name=="lwall")
        {
            bump = true;
            transform.position += new Vector3(+moveSpeed+moveSpeed, +0, +0);
        }if (other.gameObject.name=="rwall")
        {
            bump = true;
            transform.position += new Vector3(-moveSpeed-moveSpeed, +0, +0);
        }

        if (other.gameObject.name=="point")
        {
            score += 1;
            print(score);
            other.transform.position=new Vector3(UnityEngine.Random.Range(-23,23),UnityEngine.Random.Range(-7,7),0);
        }
    }
}