﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;
using Random = System.Random;

public class player : MonoBehaviour
{
    public float moveSpeed=1;//players move speed floats can be 5.5
    private bool bump;//are you currently touching a wall? yes or no
    public int score = 0;
    private void Start()
    {
        transform.position = new Vector3(0, 0, 0);//start in the center each time
    }
    private void Update()
    {
        if (Input.GetKey("up") || Input.GetKey("w")) {
            transform.position += new Vector3(+0, +moveSpeed, +0);
        }
        if (Input.GetKey("left") || Input.GetKey("a")) {
            transform.position += new Vector3(-moveSpeed, +0, +0);
        }
        if (Input.GetKey("right") || Input.GetKey("d")) {
            transform.position += new Vector3(+moveSpeed, +0, +0);
        }
        if (Input.GetKey("down") || Input.GetKey("s")) {
            transform.position += new Vector3(+0, -moveSpeed, +0);
        }
        
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name=="wall")
        {
            moveSpeed=1;//move normal once you leave the wall
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="wall")
        {
            moveSpeed = -1;//move back out of the wall
        }

        if (other.gameObject.name=="point")
        {
            score += 1;
            print(score);
        }
    }
}