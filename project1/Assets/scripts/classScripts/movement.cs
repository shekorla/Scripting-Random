using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class movement : MonoBehaviour
{
    public float gravity = 3f, jumpSpeed = 25f, speed = 1f;
    private Vector3 position;
    private CharacterController controller;
    private int jumpCount=0;
    public int jumpCountMax;
    private void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }

    void Update()
    {
        position.x = speed* Input.GetAxis("Horizontal");
        position.y -= gravity;
        if (controller.isGrounded)
        {
            position.y = 0f;
            jumpCount = 0;
        }
        if (Input.GetButtonDown("Jump") && jumpCount<jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount ++;
        }
        controller.Move(position*Time.deltaTime);
    }
}
