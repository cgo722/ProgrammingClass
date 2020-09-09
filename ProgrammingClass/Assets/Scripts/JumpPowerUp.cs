using System;
using System.Collections;
using UnityEngine;

public class JumpPowerUp : MonoBehaviour
{
    public IntData playerJumpCount, normalJumpCount, powerUpCount;
    public float waitTime = 2f;

    private void Start()
    {
        playerJumpCount.value = normalJumpCount.value;
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        playerJumpCount.value = powerUpCount.value;
        Destroy(GetComponent<MeshRenderer>());
        Destroy(GetComponent<Collider>());
        yield return new WaitForSeconds(waitTime);
        playerJumpCount.value = normalJumpCount.value;
        gameObject.SetActive(false);
    }
}
