using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] Rigidbody2D bin;
    [SerializeField] float speed;
    Vector3 worldPosition;
    Vector2 touchPos;
    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        bin = bin.GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {

        if (Input.touchCount > 0)
        {
            touchPos = Input.GetTouch(0).position;
            Vector3 worldPos = new Vector3(touchPos.x, touchPos.y, -10f);
            worldPosition = Camera.main.ScreenToWorldPoint(worldPos);

            if (touchPos.y < Screen.height / 7.5f && worldPosition.x > transform.position.x && worldPosition.x < 9f)
            {
                rb.MovePosition(worldPosition + Vector3.right * Time.deltaTime);
                bin.MovePosition(worldPosition + Vector3.right * Time.deltaTime);
            }else if(touchPos.y < Screen.height / 7.5f && worldPosition.x < transform.position.x && worldPosition.x > 0f)
            {
                rb.MovePosition(worldPosition - Vector3.right * Time.deltaTime);
                bin.MovePosition(worldPosition - Vector3.right * Time.deltaTime);
            }

        }
    }
}
