using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TopPlrHandle : MonoBehaviour
{
    public GameObject player;
    public Vector3Data mousePos;
    public Vector3 startPos;
    public NavMeshAgent myAgent;
    public intData speed;

    private playerDataHome data;
    private SpriteRenderer plrSpr;

    public void Start()
    {
        mousePos.value = startPos;
        plrSpr=player.GetComponentInChildren<SpriteRenderer>();
    }

    public void ChangePlr(playerDataHome newPlr)
    {
        plrSpr.sprite = newPlr.pSprite;
        plrSpr.color = newPlr.pColor;

    }

    public void UdateSpeed()
    {
        myAgent.speed = speed.value;
    }
}
