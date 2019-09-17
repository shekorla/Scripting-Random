using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleControl : MonoBehaviour
{
    public ParticleSystem partycalls;
    // Start is called before the first frame update
    void Start()
    {
       partycalls.Emit(100); 
    }

    private void OnMouseDown()
    {
        partycalls.Emit(100);
    }
}
