using System;
using UnityEngine;
using UnityEngine.Events;

public class eNumSwitch : MonoBehaviour
{
    public enum States
    {
        Start,
        Playing,
        End
    }

    public States currentState;

    public UnityEvent onStartEv, onPlayingEv, onEndEv;
    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case States.Start:
                onStartEv.Invoke();
                break;
            case States.Playing:
                onPlayingEv.Invoke();
                break;
            case States.End:
                onEndEv.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
