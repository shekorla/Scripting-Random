using UnityEngine;
[CreateAssetMenu]
public class playerHandeler : ScriptableObject
{
    public playerData playerDataObj;

    public void SwitchPlayer(playerData data)
    {
        playerDataObj = data;
    }

    // Update is called once per frame
    public void OnRun()
    {
        playerDataObj.Run();
    }
}
