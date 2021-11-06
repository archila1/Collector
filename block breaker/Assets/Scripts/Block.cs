using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breacksound;
    [SerializeField] Sprite[] hitSprites;
    int maxHits;
    int timesHit;

    Level level;
    GameSession score;
    private void Start()
    {
        level = FindObjectOfType<Level>();
        score = FindObjectOfType<GameSession>();
        if (tag == "Breackable")
        {
            level.CoundBreackableBlocks();

        }
        maxHits = hitSprites.Length + 1;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(tag == "Breackable")
        {
            timesHit++;
            if(maxHits <= timesHit)
            {
                DestroyBlock();
            }
            else
            {
                ShowNextHitSprite();
            }
        }
        
    }

    private void ShowNextHitSprite()
    {
        GetComponent<SpriteRenderer>().sprite = hitSprites[timesHit-1];
    }

    private void DestroyBlock()
    {
        score.UpdateScore(maxHits);
        AudioSource.PlayClipAtPoint(breacksound, Camera.main.transform.position);
        level.BlockDestroyed();
        Destroy(gameObject);
    }
}
