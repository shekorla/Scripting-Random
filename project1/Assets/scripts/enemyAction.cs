using System;
using UnityEngine;
using UnityEngine.Events;


public class enemyAction : MonoBehaviour
{
    public UnityEvent start;
    
    // Start is called before the first frame update
    void Start()
    {
        start.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        start.Invoke();
        gameObject.transform.position += transform.forward*Time.deltaTime;
        transform.rotation=new Quaternion(+0,+0,0,+0);
    }
}
