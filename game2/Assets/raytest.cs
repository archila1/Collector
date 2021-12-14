using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raytest : MonoBehaviour
{
    RaycastHit2D hit;
    Vector2 touchPos;
    Vector2 worldPos;
    void Start()
    {
        //laserLine = GetComponent<LineRenderer>();

    }


    void FixedUpdate()
    {

        if (Input.touchCount > 0)
        {   
            touchPos =  Input.GetTouch(0).position;
            worldPos = Camera.main.WorldToViewportPoint(touchPos);
            hit = Physics2D.Raycast(touchPos, Vector2.zero);
            Debug.Log("touch pos is " + touchPos);
            Debug.Log("worldfpost is " + worldPos);
            Debug.Log(hit);
        }

    }
}

