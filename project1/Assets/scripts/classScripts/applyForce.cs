using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class applyForce : MonoBehaviour
{
    private Rigidbody rb;

    public Vector3Data forceDirection;
    public float force = 3f;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(forceDirection.value*force);
    }
}
