using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Checkpoints : MonoBehaviour
{
    public GameObject player;
    public CharacterController pChara;
    public Vector3 checkpoint;
    public UnityEvent death;
    private void Start()
    {
        checkpoint=Vector3.zero;
        player=GameObject.FindWithTag("Player");
        pChara = player.GetComponent<CharacterController>();

    }
    public void YouDied()
    {
        pChara.transform.position = checkpoint;
        player.transform.position=checkpoint;
        death.Invoke();
    }

    public void updateCheckLoc(GameObject Trigger)
    {
        checkpoint = Trigger.transform.position;
    }
}
