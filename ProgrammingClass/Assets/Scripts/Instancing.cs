using System;
using UnityEngine;



public class Instancing : MonoBehaviour
{
    public GameObject prefab;

    //make a method to call the instance method

    public void Instance()
    {
        var location = Vector3.zero;
        var rotationDirection = new Vector3(0, 45, 0);
        Instantiate(prefab, location, Quaternion.Euler(rotationDirection));
    }
}
