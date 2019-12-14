using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class coroutineClass : MonoBehaviour
{
    public bool canRun = true;
    public SpriteRenderer sprite;
    public ColorColl list;
    public int colorNum=0;
    private WaitForSeconds wfsObj;
    public float seconds=1;
    public intData index;
    public UnityEvent textEvent;

    private void Start()
    {
        index.value = 10;
        wfsObj=new WaitForSeconds(seconds);
    }

    public void Run()
    {
        StartCoroutine(OnRun());
    }
    
    IEnumerator OnRun()
    {
        while (index.value>=0)
        {
            textEvent.Invoke();
            index.value--;
            sprite.color = list.colorList[colorNum];
            if (colorNum<9)
            {
                colorNum += 1;
            }
            else
            {
                colorNum = 0;
            }
            yield return wfsObj;
        }
    }
}
