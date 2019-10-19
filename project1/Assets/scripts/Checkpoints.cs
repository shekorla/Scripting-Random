using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Checkpoints : MonoBehaviour
{
    public GameObject player;
    public Vector3 checkpoint;
    public UnityEvent death;
    public playerData pData;
    private void FindPlayer(GameObject thisOne)
    {
        player = thisOne;
        print("now my child");
    }
    private void Start()
    {
        checkpoint=Vector3.zero;
        pData.instanceAction = FindPlayer;

    }
    public void YouDied()
    {
        player.transform.position=checkpoint;
        death.Invoke();
    }

    public void updateCheckLoc(GameObject Trigger)
    {
        checkpoint = Trigger.transform.position;
    }
}
