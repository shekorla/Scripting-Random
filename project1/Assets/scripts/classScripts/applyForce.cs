﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class applyForce : MonoBehaviour
{
    private Rigidbody rb;

    public Vector3 forces;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(forces);
    }
}
