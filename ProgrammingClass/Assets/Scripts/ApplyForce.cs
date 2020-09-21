using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{

    private Rigidbody rBody;
    public float force = 30f;
    public Vector3Data rotation;

    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        var forceDirection = transform.right;
        //forceDirection needs to be based on Player rotation (hint SO)
        rBody.AddForce(forceDirection * force);
    }

    //need a firing method- its in instancing
}
