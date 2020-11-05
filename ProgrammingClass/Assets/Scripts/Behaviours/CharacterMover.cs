using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float rotateSpeed = 120f, gravity = -9.81f, jumpForce = 10f;
    public FloatData normalSpeed, fastSpeed;
    public IntData playerJumpCount, healthData;

    protected CharacterController controller;
    protected Vector3 movement;
    protected bool canMove = true;
    protected readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    protected float vInput, hInput;
    protected FloatData moveSpeed;

    protected float yVar;
    private int jumpCount;

    private void OnEnable()
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
        StartCoroutine(Move());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

    private void Update()
    {

        if (Input.GetButtonDown("Jump") && jumpCount < playerJumpCount.value)
        {
            yVar = jumpForce;
            jumpCount++;
        }
    }

    protected IEnumerator Move()
    {
        canMove = true;
        while (canMove)
        {
            OnMove();
            Health();
            yield return wffu;
        }
    }

    protected virtual void OnInput()
    {
        hInput = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, hInput, 0);
        vInput = Input.GetAxis("Vertical") * moveSpeed.value;
        movement.Set(0, yVar, vInput);
    }

    private void OnMove()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = fastSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = normalSpeed;
        }

        OnInput();

        yVar += gravity * Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            jumpCount = 0;
        }

        movement = transform.TransformDirection(movement);
        controller.Move((movement) * Time.deltaTime);
    }

    private void Health()
    {
        if (healthData.value <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}