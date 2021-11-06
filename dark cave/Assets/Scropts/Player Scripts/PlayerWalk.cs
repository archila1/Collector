using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6f, jumpForce = 10f;


    private Rigidbody2D myBody;
    private Vector3 tempPos;


    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        tempPos = transform.position;
    }

    private void Update()
    {
        HandleMovementWithTransform();
    }

    void HandleMovementWithTransform()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            tempPos.x -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            tempPos.x += moveSpeed * Time.deltaTime;
        }
        transform.position = tempPos;
    }
}
