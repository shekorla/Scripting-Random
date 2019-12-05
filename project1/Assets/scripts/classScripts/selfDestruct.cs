using UnityEngine;

public class selfDestruct : MonoBehaviour
{
    public float delay=3f;
    void Start()
    {
        Destroy(gameObject, delay);
    }

    public void DestoryOnImpact(playerData other)
    {
        Destroy(gameObject);
    }
}
