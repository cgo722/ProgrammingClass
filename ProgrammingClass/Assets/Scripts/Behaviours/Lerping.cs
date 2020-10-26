using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour
{

    public Vector3 vOne, vTwo;
    public float value;

    public int waitTime;
    private WaitForSeconds wfs;

    private void Update()
    {
        Move();

    }

    private void Move()
    {
        var direction1 = Vector3.Lerp(vOne, vTwo, value);
        var direction2 = Vector3.Lerp(vTwo, vOne, value);
        if (value <= 1)
        {
            value += 0.3f * Time.deltaTime;
            transform.position = direction1;
        }
        if (value >= 1)
        {
            value = -0.3f * Time.deltaTime;
            transform.position = direction2;
        }

    }

   


}
