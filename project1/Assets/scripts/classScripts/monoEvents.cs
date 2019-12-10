using UnityEngine;
using UnityEngine.Events;

public class monoEvents : MonoBehaviour
{
    public UnityEvent startEvent, secEve;
    void Start()
    {
        startEvent.Invoke();
    }

    public void callSecEve()
    {
        secEve.Invoke();
    }

}
