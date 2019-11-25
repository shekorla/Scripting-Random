using UnityEngine;

public class tpDwnWepHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Destroy(other);
            print("killed an enemy");
        }
    }
}
