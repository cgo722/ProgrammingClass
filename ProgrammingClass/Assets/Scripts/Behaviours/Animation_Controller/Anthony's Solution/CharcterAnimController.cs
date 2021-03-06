﻿using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(CharacterController))]
public class CharcterAnimController : MonoBehaviour
{
    public UnityEvent startEvent;
    public float speed = 5;
    public CharacterBrains brain;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        startEvent.Invoke();
    }
    private void Update()
    {
        var position = brain.Move(speed * Input.GetAxis("Horizontal"));
        var newPosition = position * Time.deltaTime;
        controller.Move(newPosition);
    }
}