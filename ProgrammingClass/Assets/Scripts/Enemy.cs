using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public IntData health;
    public float waitTime = 10f;


    private IEnumerator OnTriggerEnter(Collider other)
    {
        health.value--;
        yield return new WaitForSeconds(waitTime);
    }
   
    
}
