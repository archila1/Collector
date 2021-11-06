using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectCollors : MonoBehaviour
{
    [SerializeField] Text leftBoxes, rightBoxes;
    [SerializeField] public Image leftColor, rightColor;  
    [SerializeField] int collectLeft, collectRight;
    [SerializeField] SpriteRenderer[] collorsToCollect;
    [SerializeField] GameObject win;

    private void Awake()
    {
        Time.timeScale = 1;
        SetCollors();
        SetTags();
        UpdateRightValue(0);
        UpdateLeftValue(0);
    }

    private void Update()
    {
        if (collectLeft <= 0 && collectRight <= 0)
        {
            Time.timeScale = 0;       
            win.SetActive(true);
        }
    }
    private void SetCollors()
    {
        leftColor = leftColor.GetComponent<Image>();
        rightColor = rightColor.GetComponent<Image>();
        leftColor.color = collorsToCollect[0].GetComponent<SpriteRenderer>().color; 
        rightColor.color = collorsToCollect[1].GetComponent<SpriteRenderer>().color;       
    }
    public void SetTags()
    {
        if (collorsToCollect[0].tag == "blue")
        {
            leftColor.tag = "B";
        } else if (collorsToCollect[0].tag == "red")
        {
            leftColor.tag = "R";
        } else if(collorsToCollect[0].tag == "green")
        {
            leftColor.tag = "G";
        }
        else if (collorsToCollect[0].tag == "yellow")
        {
            leftColor.tag = "Y";
        }

        if (collorsToCollect[1].tag == "blue")
        {
            rightColor.tag = "B";
        }
        else if (collorsToCollect[1].tag == "red")
        {
            rightColor.tag = "R";
        }
        else if (collorsToCollect[1].tag == "green")
        {
            rightColor.tag = "G";
        }
        else if (collorsToCollect[1].tag == "yellow")
        {
            rightColor.tag = "Y";
        }
    }

    public void UpdateLeftValue(int val)
    {
        collectLeft -= val;
        if (collectLeft <= 0)
        {
            leftBoxes.text = "0";
        }
        else
        {
            leftBoxes.text = collectLeft.ToString();
        }
    }

    public void UpdateRightValue(int val)
    {
        collectRight -= val;
        if (collectRight <= 0)
        {
            rightBoxes.text = "0";
        }
        else
        {
            rightBoxes.text = collectRight.ToString();
        }
    }
}
