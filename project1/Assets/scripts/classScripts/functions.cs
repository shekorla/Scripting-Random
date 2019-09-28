using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    public Color playerColor = Color.red;

    public GameObject player;
    public ScriptableObject red,green,blue,vio;

    public string playerName;

    private int myNum;

    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(ConfigGameObject());
        ConfigGameObject();
        ConfigHWPlayer(red);
        ConfigHWPlayer(blue);
        ConfigHWPlayer(vio);
        ConfigHWPlayer(green);
    }

    private int AddNum(int A, int B)
    {
        print(A+B);
        return A + B;
    }

    private string WelcomePlayer()
    {
       //give weapons
       //add player to database
       return playerName + "Welcome to the game!";
    }

    private float IncreaseSpeed( float multiply)
    {
        return speed * multiply;
    }

    private void OnTriggerEnter(Collider other)
    {
        speed = IncreaseSpeed(.5f);
    }

    private GameObject ConfigGameObject()
    {
        var nPlayer = Instantiate(player);
        nPlayer.layer = 0;
        nPlayer.SetActive(true);
        nPlayer.tag = "Player";
        nPlayer.transform.position=Vector3.zero;
        nPlayer.name = playerName;
        nPlayer.GetComponent<Renderer>().material.color = playerColor;
        return player;
    }
    private ScriptableObject ConfigHWPlayer(ScriptableObject play)
    {
        print(play);
        var hwPlayer = Instantiate(play);
        hwPlayer.name = play.name;
        return play;
    }
}
