using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public float delayTime = 0.1f;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
