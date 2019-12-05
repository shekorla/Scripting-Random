using UnityEngine;
using UnityEngine.Events;

public class gameActHandle : MonoBehaviour
{

    public gameAction gameActObj;
    public UnityEvent handlerEve;

    private void Start()
    {
        gameActObj.action = RaiseHandler;
    }

    public void RaiseHandler()
    {
        handlerEve.Invoke();
    }
}
