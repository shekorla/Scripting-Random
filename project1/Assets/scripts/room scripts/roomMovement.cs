using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class roomMovement : MonoBehaviour
{
    public float gravity = 3f, jumpSpeed = 25f, mvSpeed = 1f, rot = 0;
    public int jumpCountMax;

    private Vector3 position;
    private CharacterController controller;
    private int jumpCount = 0;
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //change x y and z according to time passing and buttons being pressed
        position.x =+ Input.GetAxis("Horizontal") * mvSpeed;
        position.z =+ Input.GetAxis("Vertical") * mvSpeed;
        position.y -= gravity;
        //if on ground no jump
        if (controller.isGrounded)
        {
            position.y = 10f;
            jumpCount = 0;
        }
        //double jump ability and normal jump
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        controller.Move(position * Time.deltaTime);
    }
}
