using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Knockback : MonoBehaviour
{

    public float pushPower;
    public float playerKB = 10f;

    public Vector3 move;

    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        move = transform.TransformDirection(move);
        controller.Move(move * playerKB * Time.deltaTime);
    }

private IEnumerator KnockBack (ControllerColliderHit hit)
    {
        var i = 2f;
        move = hit.collider.attachedRigidbody.velocity * (i * playerKB);
        while (i > 0)
        {
            yield return new WaitForFixedUpdate();
            i -= 0.1f;
        }
        move = Vector3.zero;
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic)
        {
            return;
        }

        if (hit.moveDirection.y < -0.3)
        {
            return;
        }

        var pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        body.velocity = pushDir * pushPower;
    }
}
