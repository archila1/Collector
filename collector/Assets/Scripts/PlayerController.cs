using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] GameObject bin;
    Rigidbody2D bin2D;

    private void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        bin2D = bin.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        if (Input.touchCount > 0)
        {
            Debug.Log(Input.GetTouch(0));
        }
    }
}
