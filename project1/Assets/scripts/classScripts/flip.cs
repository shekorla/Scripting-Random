﻿
using UnityEngine;

public class flip : MonoBehaviour
{
    public Vector3Data data;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
          transform.rotation= Quaternion.Euler(0,180,0);
          data.value.x =-1f;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation=Quaternion.Euler(0,0,0);
            data.value.x = 1f;
        }
    }
}
