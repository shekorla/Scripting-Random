using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    public void OnMouseDown()
    {
        print("bang!");
        bullet.transform.LookAt(Input.mousePosition);
        bullet.transform.position += transform.forward;
        var position = player.transform.position;
        Instantiate(bullet, new Vector3(position.x, position.y, position.x),transform.rotation);
    }
}
