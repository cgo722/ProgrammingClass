using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Knockback : MonoBehaviour
{

    public FloatData power;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.gameObject)
        {
            rb.AddForce(transform.position * power.value * Time.deltaTime,ForceMode.Impulse);
        }
    }
}
