using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public UnityEvent triggerStayEvent;
    public UnityEvent triggerExitEvent;
    public float delayTime = 0.1f;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
    private void OnTriggerStay(Collider other)
    {
        triggerStayEvent.Invoke();
    }
    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }

}
