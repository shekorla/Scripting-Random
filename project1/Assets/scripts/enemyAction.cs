using UnityEngine;
using UnityEngine.Events;


public class enemyAction : MonoBehaviour
{
    public UnityEvent start;

    public float speed = .5f;
    // Start is called before the first frame update
    void Start()
    {
        start.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += transform.forward*speed;
    }
}
