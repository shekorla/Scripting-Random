using UnityEngine;
using UnityEngine.Events;

public class startBehavior : MonoBehaviour
{
    public UnityEvent startEve;
    private void Start() {
        print("hello world");
        startEve.Invoke();
    }
}
