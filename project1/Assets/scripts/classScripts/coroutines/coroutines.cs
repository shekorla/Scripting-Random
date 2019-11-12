using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class coroutines : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float seconds =10f;
    public int counter=10;
    public bool canRun;
    private WaitForSeconds wFsObj;

    public void Awake()
    {
        wFsObj=new WaitForSeconds(seconds);
    }

    public void CallCoroutine()
    {
        StartCoroutine(RunCoruoutien());
    }
    IEnumerator RunCoruoutien()
    {
        startEvent.Invoke();
        while (counter>0)
        {
            repeatEvent.Invoke();
            yield return wFsObj;
            counter--;
        }
        while (canRun)
        {
            repeatEvent.Invoke();
            yield return wFsObj;
        }
        endEvent.Invoke();
    }

}
