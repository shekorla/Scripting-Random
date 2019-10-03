using UnityEngine;
using UnityEngine.Events;

public class monoEvents : MonoBehaviour
{
    public UnityEvent startEvent;
    void Start()
    {
        startEvent.Invoke();
    }

}
