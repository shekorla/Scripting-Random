using UnityEngine;

public class functionsHome : MonoBehaviour
{
    public playerDataHome red,green,blue,vio;

    void Start()
    {
        ConfigHWPlayer(red);
        ConfigHWPlayer(blue);
        ConfigHWPlayer(vio);
        ConfigHWPlayer(green);
    }

    private GameObject ConfigHWPlayer(playerDataHome play)
    {
        var hwPlayer = Instantiate(play.prefab);
        var look = hwPlayer.GetComponentInChildren<SpriteRenderer>();
        look.sprite = play.pSprite;
        look.color = play.pColor;
        hwPlayer.name = play.nameVar;
        hwPlayer.transform.position=new Vector3(play.xOffset,0,0);
        return hwPlayer;
    }
}
