using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public float moveSpeed = 1; //players move speed floats can be 5.5
    public int score = 0;
    public UnityEvent Event;
    private Text text;
    private Vector3 move;
    public CharacterController controller;

    private void Start()
    {
        text = GameObject.Find("scoreboard").GetComponent<Text>();
        transform.position = new Vector3(0, 0, 0); //start in the center each time
    }

    private void Update()
    {
        move.x = moveSpeed * Input.GetAxis("Horizontal"); 
        move.y = moveSpeed * Input.GetAxis("Vertical");
        controller.Move(move);
        
    }
    
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "point")
        {
            score += 1;
            text.text = "Score:" + score;
            Event.Invoke();
            other.transform.position =
                new Vector3(UnityEngine.Random.Range(-23, 23), UnityEngine.Random.Range(-7, 7), 0);
        }
    }
}
