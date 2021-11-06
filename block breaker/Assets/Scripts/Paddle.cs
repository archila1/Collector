using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    float screenWidthInUnits = 16f;
    GameSession gameSession;
    Ball ball;


    private void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        ball = FindObjectOfType<Ball>();
    }

    void Update()
    {
        MovePaddle();
    }


    private void MovePaddle()
    {
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(GetXPos(), 1f, 15f);
        transform.position = paddlePos;
    }

    private float GetXPos()
    {
        if (gameSession.IsAutoplayEnabled())
        {
            return ball.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
        }
    }
}
