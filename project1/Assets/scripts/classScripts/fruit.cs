using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruit : MonoBehaviour
{
    public bool appleIsRipe, orangeIsRipe, peachIsRipe;
    // Start is called before the first frame update
    void Start()
    {
        if (appleIsRipe)
        {
            print("Go pick the apple");
        }
        else if (orangeIsRipe)
        {
            print("Go pick the orange");  
        }
        else if (peachIsRipe)
        {
            print("Go pick the peach");  
        }
        else
        {
            print("nothing is ripe");
        }

    }
}
