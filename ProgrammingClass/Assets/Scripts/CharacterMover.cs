using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 movement;
    public float gravity = -9.81f;
    public float moveSpeed = 5f;
    public float rotateSpeed = 30f;
    public float runSpeed = 3f;
    public float jumpForce = 10f;
    public int jumpCount;
    public int jumpMax = 2;
    private float yVar;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        
        var vInput = Input.GetAxis("Vertical")*moveSpeed;
        movement.Set(vInput, yVar, 0);

        var hInput = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, hInput, 0);

        

        yVar += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpMax)
        {
            yVar = jumpForce;
            jumpCount++;
            Debug.Log("Jump");
        }

        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);


        
    }
}
