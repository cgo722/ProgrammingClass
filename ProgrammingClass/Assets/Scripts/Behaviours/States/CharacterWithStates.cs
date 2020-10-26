//using System;
//using UnityEngine;
//[RequireComponent(typeof(CharacterController))]
//public class CharacterWithStates : StateMachine
//{
//    private CharacterController controller;
//    protected State states;

//    private Vector3 movement;
//    public float moveSpeed = 3;
//    public float gravity = -9.81f;


//    private void Start()
//    {
//        controller = GetComponent<CharacterController>();
//    }

//    private void SetState()
//    {
//        var newInput = Input.GetAxis("Vertical") * moveSpeed;

//        switch (states)
//        {
//            case states:
//                print("I just be standing");
//                break;
//            case states.StandardWalk:
//                movement.Set(newInput, gravity, 0);
//                print("Walk");
//                break;
//            case states.WallCrawl:
//                movement.Set(0, newInput, 0);
//                print("Crawl");
//                break;
//            case states.Jump:
//                print("KnockBack");
//                break;
//        }

//        var newMovement = movement * Time.deltaTime;
//        controller.Move(newMovement);
//    }
//}
