using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 movement;
    public float gravity = 9.81f;
    public float moveSpeed = 3f;
    public float jumpForce = 10f;
    public float runSpeed = 3f;
    public bool canJump;
    public int jumpCount;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && jumpCount < 2)
        {
            movement.y = jumpForce;
            canJump = false;
            jumpCount++;
        }

        if (controller.isGrounded)
        {
            movement.y = 0;
            canJump = true;
            jumpCount = 0;
        }
        else
        {
            movement.y -= gravity;
            canJump = false;
            
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(movement * runSpeed * Time.deltaTime);
        }
        else
        {
            controller.Move(movement * moveSpeed * Time.deltaTime);
        }
        
        
    }
}
