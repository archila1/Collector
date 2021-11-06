using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameSession : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int currentscore = 0;
    [SerializeField] bool isAutoPlayEnabled;
    private void Awake()
    {
        int GameSession = FindObjectsOfType<GameSession>().Length;
        if (GameSession > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
        
    }

    public void UpdateScore(int value)
    {
        currentscore += value;
        scoreText.text = $"Score: {currentscore}";
    }

    public void ResetScore()
    {
        Destroy(gameObject);
    }
    
    public bool IsAutoplayEnabled()
    {
        return isAutoPlayEnabled;
    }
}
