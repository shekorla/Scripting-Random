using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    public ScriptableObject ammoCount;
    public void OnMouseDown()
    {
        print("bang!");
        bullet.transform.LookAt(Input.mousePosition);
        var position = player.transform.position;
        Instantiate(bullet, new Vector3(position.x, position.y, 0),transform.rotation);
    }
}
