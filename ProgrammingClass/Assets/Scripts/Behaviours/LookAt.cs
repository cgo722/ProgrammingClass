using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform lookObj;

    private void Update()
    {
        Transform transform1;
        (transform1 = transform).LookAt(lookObj);
        var transformRotation = transform1.eulerAngles;
        transformRotation.x = 0;
        transform.rotation = Quaternion.Euler(transformRotation);
    }
}
