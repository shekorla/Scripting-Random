using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bullet, player;
    public ScriptableObject ammoCount;
    

    public void OnMouseDown()
    {
        //print("bang!");
        var position = player.transform.position;
        Instantiate(bullet, new Vector3(position.x, position.y, 0),transform.rotation);
    }
}
