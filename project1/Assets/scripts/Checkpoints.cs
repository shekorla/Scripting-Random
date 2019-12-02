using UnityEngine;
using UnityEngine.Events;

public class Checkpoints : MonoBehaviour
{
    public GameObject player;
    public CharacterController pChara;
    public Vector3 checkpoint;
    public UnityEvent death;
    
    private bool check2 = false;
    private void Start()
    {
        checkpoint=Vector3.zero;
        player=GameObject.FindWithTag("Player");
        pChara = player.GetComponent<CharacterController>();
        

    }
    public void YouDied()
    {
        pChara.enabled = false;
        player.transform.position=checkpoint;
        pChara.enabled = true;
        death.Invoke();
    }
    private void Update()
    {
        if (player.transform.position.x>=120f&&check2==false)
        {
            checkpoint = gameObject.transform.position;
            check2 = true;
            print("one");
        }
    }
}
