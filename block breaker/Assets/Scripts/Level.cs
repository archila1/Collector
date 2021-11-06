using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breackableBlocks;
    SceneLoader sceneloader;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void CoundBreackableBlocks()
    {
        breackableBlocks++;
    }

    public void BlockDestroyed()
    {
        breackableBlocks--;
        if (breackableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
