﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class pointmove : MonoBehaviour
{
    private int topLimit = 7;
    private int bottLimit = -8;
    private int leftLimit = -22;
    private int rightLimit = 23;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name=="player")
        {
            //transform.position=new Vector3(Random.Range(leftLimit,rightLimit),Random.Range(bottLimit,topLimit),0);
        }
    }
}
