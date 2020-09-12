﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Vector3Data vData;

    private void OnEnable()
    {
        vData.value = new Vector3 (0, 2, 0);
    }
    //set the vData from the position value

    private void OnTriggerEnter(Collider other)
    {
        //set the location data of the player to the current spawn point
        vData.value = transform.position;
    }
}
