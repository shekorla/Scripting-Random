using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class player : MonoBehaviour
{
    private int moveSpeed=(1);
    private void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }
    private void Update()
    {
        if (Input.GetKey("up")||Input.GetKey("w")) {
            transform.position += new Vector3(+0, + moveSpeed, +0);
        }
        if (Input.GetKey("left")||Input.GetKey("a")) {
            transform.position += new Vector3(-moveSpeed, +0, +0);
        }
        if (Input.GetKey("right")||Input.GetKey("d")) {
            transform.position += new Vector3(+moveSpeed, +0, +0);
        }
        if (Input.GetKey("down")||Input.GetKey("s")) {
            transform.position += new Vector3(+0, -moveSpeed, +0);
        }
    }
    public void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.name);
    }
}