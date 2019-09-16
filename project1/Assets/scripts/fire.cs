using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Events;

public class fire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    private void OnMouseDown()
    {
        print("bang!");
        bullet.transform.LookAt(Input.mousePosition);
        bullet.transform.position += transform.forward;
        var position = player.transform.position;
        Instantiate(bullet, new Vector3(position.x,position.y,position.x), transform.rotation);
    }
}
