using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsAfter : MonoBehaviour
{
    public UnityEvent triggerEnterEventAfter;
    public float delayTime;
    private WaitForSeconds waitObj;

    private void Start()
    {
        waitObj = new WaitForSeconds(delayTime);
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        triggerEnterEventAfter.Invoke();
        yield return waitObj;
    }
}
