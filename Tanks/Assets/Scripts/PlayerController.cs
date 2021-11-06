using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Sprite[] playerSprites;

    void Start()
    {
        SpriteRenderer playerSprite = GetComponent<SpriteRenderer>();
    }


    void FixedUpdate()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > 0)
        {
            transform.Translate(7 * Time.deltaTime * Vector2.left);
            transform.eulerAngles = Vector3.left * 270;
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 23)
        {
            transform.Translate(7 * Time.deltaTime * Vector2.right);
            transform.Rotate = new Vector3(1, 0, 50);
        }

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < 19f)
        {
            transform.Translate(7 * Time.deltaTime * Vector2.up);
            transform.eulerAngles = Vector3.forward;
        }

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > 0)
        {
            transform.Translate(7 * Time.deltaTime * Vector2.down);
            transform.eulerAngles = new Vector3(0,0,180);
        }
    }



}
