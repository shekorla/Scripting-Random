using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEvent;
    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        Move(gameObject);
    }
    public void Move(GameObject myself)
    {
        myself.transform.position=new Vector3(UnityEngine.Random.Range(-23,23),UnityEngine.Random.Range(-7,7),0);
    }
}
