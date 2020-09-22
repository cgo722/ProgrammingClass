using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{

    private Rigidbody rBody;
    public float force = 30f;
    public Vector3Data rotation;


    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = transform.right;

        rBody.AddForce(forceDirection * force);
    }

}
