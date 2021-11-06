using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BoxCounter : MonoBehaviour
{
    CollectCollors collectCollors;
    int boxesInCart;
    int red;
    int blue;
    int green;
    int yellow;
    public int lives;
    [SerializeField] Text livesLeft;

    private void Awake()
    {
        collectCollors = FindObjectOfType<CollectCollors>();
        boxesInCart = 0;
        red = 0;
        green = 0;
        yellow = 0;
        blue = 0;
        livesLeft.text = $"Lives: {lives}";
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("green"))
        {
            collision.tag = "G";
            green++;
        }
        if (collision.CompareTag("red"))
        {
            red++;
            collision.tag = "R";
        }
        if (collision.CompareTag("yellow"))
        {
            yellow++;
            collision.tag = "Y";
        }
        if (collision.CompareTag("blue"))
        {
            blue++;
            collision.tag = "B";
        }

        boxesInCart++;
        if (boxesInCart > 2)
        {
            Debug.Log($"there are {boxesInCart} boxes in cart");
            ClearBin();
        }
    }

    private void ClearBin()
    {
        if (red > 2)
        {
            Debug.Log($"red {red}");
            if ("R" == collectCollors.leftColor.tag)
            {
                collectCollors.UpdateLeftValue(3);
                collectCollors.leftColor.tag = "Untagged";
            }
            else if ("R" == collectCollors.rightColor.tag)
            {
                collectCollors.UpdateRightValue(3);
                collectCollors.rightColor.tag = "Untagged";
            }
            GameObject[] boxes = GameObject.FindGameObjectsWithTag("R");
            foreach (GameObject box in boxes)
            {
                GameObject.Destroy(box);
            }

            red = 0;
            boxesInCart -= 3;
            collectCollors.SetTags();
        }else if (blue > 2)
        {
            Debug.Log($"blue {red}");
            if ("B" == collectCollors.leftColor.tag)
            {
                collectCollors.UpdateLeftValue(3);
                collectCollors.leftColor.tag = "Untagged";
            }
            else if ("B" == collectCollors.rightColor.tag)
            {
                collectCollors.UpdateRightValue(3);
                collectCollors.rightColor.tag = "Untagged";
            }
            GameObject[] boxes = GameObject.FindGameObjectsWithTag("B");
            foreach (GameObject box in boxes)
            {
                GameObject.Destroy(box);
            }

            blue = 0;
            boxesInCart -= 3;
            collectCollors.SetTags();
        }else if (green > 2)
        {
            Debug.Log($"green {green}");
            if ("G" == collectCollors.leftColor.tag)
            {
                collectCollors.UpdateLeftValue(3);
                collectCollors.leftColor.tag = "Untagged";
            }
            else if ("G" == collectCollors.rightColor.tag)
            {
                collectCollors.UpdateRightValue(3);
                collectCollors.rightColor.tag = "Untagged";
            }
            GameObject[] boxes = GameObject.FindGameObjectsWithTag("G");
            foreach (GameObject box in boxes)
            {
                GameObject.Destroy(box);
            }

            green = 0;
            boxesInCart -= 3;
            collectCollors.SetTags();
        }else if (yellow > 2)
        {
            Debug.Log($"yellow {yellow}");
            if ("Y" == collectCollors.leftColor.tag)
            {
                collectCollors.UpdateLeftValue(3);
                collectCollors.leftColor.tag = "Untagged";
            }
            else if ("Y" == collectCollors.rightColor.tag)
            {
                collectCollors.UpdateRightValue(3);
                collectCollors.rightColor.tag = "Untagged";
            }
            GameObject[] boxes = GameObject.FindGameObjectsWithTag("Y");
            foreach (GameObject box in boxes)
            {
                GameObject.Destroy(box);
            }

            yellow = 0;
            boxesInCart -= 3;
            collectCollors.SetTags();
        }
        else
        {
            Debug.Log($"lives left {lives}");
            if (boxesInCart > 4)
            {
                
                lives--;
                livesLeft.text = $"Lives: {lives}";
                if (lives <= 0)
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
    }
}
