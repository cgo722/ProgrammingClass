using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBefore : MonoBehaviour
{
    public UnityEvent triggerEnterEventBefore;
    public float delayTime;
    private WaitForSeconds waitObj;

    private void Start()
    {
        waitObj = new WaitForSeconds(delayTime);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return waitObj;
        triggerEnterEventBefore.Invoke();
    }
}
