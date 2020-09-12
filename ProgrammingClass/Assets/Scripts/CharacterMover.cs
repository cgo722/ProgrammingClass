

using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMover : MonoBehaviour
{

    private CharacterController controller;
    private Vector3 movement;
    public float gravity = -9.81f, rotateSpeed = 30f, jumpForce = 10f, yVar;
    public int jumpCount;

    public IntData jumpMax;
    public IntData health;

    public FloatData moveSpeed;
    public FloatData runSpeed;

    public Vector3Data currentSpawnPoint;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        health.value = 2;
    }

    void Update()
    {
        
        var vInput = Input.GetAxis("Vertical") * moveSpeed.value;
        movement.Set(vInput, yVar, 0);

        var hInput = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, hInput, 0);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            movement.Set(vInput * runSpeed.value, yVar, 0);
        }
        

        yVar += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpMax.value)
        {
            yVar = jumpForce;
            jumpCount++;
            Debug.Log("Jump");
        }

        movement = transform.TransformDirection(movement);
        controller.Move(movement * Time.deltaTime);

        if(health.value == 0)
        {
            Destroy(gameObject);
        }
        
    }



    private void OnEnable()
    {
        //set the position of the player ot the location data of the player
    }
}
