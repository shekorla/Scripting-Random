using System;
using System.Collections;
using UnityEngine;

public class coroutineClass : MonoBehaviour
{
    public bool canRun = true;
    public SpriteRenderer sprite;
    public ColorColl list;
    public int colorNum=0;
    private WaitForSeconds wfsObj;
    public float seconds=1;
    public intData index;
    
    public void Run()
    {
        wfsObj=new WaitForSeconds(seconds);
        StartCoroutine(OnRun());
    }
    
    IEnumerator OnRun()
    {
        while (index.value>0)
        {
            Debug.Log(index.value);
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
        }
        yield return wfsObj;
    }
//hw write a new script that will display the index as a ui text obj and update. visible count down.
    
}
