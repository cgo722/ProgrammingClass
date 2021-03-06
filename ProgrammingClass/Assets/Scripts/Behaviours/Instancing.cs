﻿using System;
using UnityEngine;



public class Instancing : MonoBehaviour
{
    public GameObject prefab;
    public Vector3Data data;

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
        var location = data.value;
        var rotationDirection = new Vector3(0, 45, 0);
        Instantiate(prefab, location, transform.rotation);
    }
}
