﻿using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Vector3Data vData;

   

    private void OnTriggerEnter(Collider other)
    {
        vData.value = transform.position;
    }
}
