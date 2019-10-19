using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Checkpoints : MonoBehaviour
{
    public GameObject player;
    public Vector3 checkpoint;
    public UnityEvent death;

    private void Start()
    {
        checkpoint=Vector3.zero;
    }
    void YouDied()
    {
        player.transform.position=checkpoint;
        death.Invoke();
    }
}
