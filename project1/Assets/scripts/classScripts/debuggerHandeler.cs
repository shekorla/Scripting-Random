using UnityEngine;

public class debuggerHandeler : MonoBehaviour
{
    public Debugger debuggerObj;

    public void SwitchDebugger(Debugger newDebuggerObj)
    {
        debuggerObj = newDebuggerObj;
    }

    void Update()
    {
        debuggerObj.OnDebug();
    }
}
