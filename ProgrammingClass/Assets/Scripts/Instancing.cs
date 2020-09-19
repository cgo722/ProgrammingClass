using System;
using UnityEngine;



public class Instancing : MonoBehaviour
{
    public GameObject prefab;
    public Vector3Data data;
    //make a method to call the instance method

    public void Update()
    {
        data.value = transform.position;
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instance();
        }
    }
    public void Instance()
    {
        var location = new Vector3(data.value.x, data.value.y, data.value.z);
        //var rotationDirection = new Vector3(0, 45, 0);
        Instantiate(prefab, location, transform.rotation);
    }
}
