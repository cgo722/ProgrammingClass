using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocator : MonoBehaviour
{
    private Camera cam;
    public Transform pointObj;

    private void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        RaycastHit hit;

        if(Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, 100))
        {
            pointObj.position = hit.point;
        }
    }
}
