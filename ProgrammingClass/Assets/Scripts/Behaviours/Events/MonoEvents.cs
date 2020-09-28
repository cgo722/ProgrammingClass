using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent start, onEnabled;

    private void Start()
    {
        start.Invoke();
    }

    private void OnEnable()
    {
        onEnabled.Invoke();
    }
}
