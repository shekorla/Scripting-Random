using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = System.Random;

public class pointMove : MonoBehaviour
{
    private int topLimit = 7;
    private int bottLimit = -8;
    private int leftLimit = -22;
    private int rightLimit = 23;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name=="player")
        {
           // transform.position=new Vector3(Random(leftLimit,rightLimit),Random(bottLimit,topLimit),0);
            
        }
    }
}
