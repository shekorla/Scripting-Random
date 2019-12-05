using UnityEditor;
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
        rb.AddForce(forceDirection.value*force);
    }
}
