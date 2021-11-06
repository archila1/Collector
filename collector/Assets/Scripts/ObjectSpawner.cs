using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] BoxPrefabs;
    [SerializeField] float leftBorder, rightBorder;
    [SerializeField] float minTime, maxTime;

    int boxIndex;

    private void Start()
    {
        InvokeRepeating("SpawnBoxes", minTime, maxTime);
    }

    private void SpawnBoxes()
    {
        boxIndex = Random.Range(0, BoxPrefabs.Length);
        Instantiate(BoxPrefabs[boxIndex], new Vector2(Random.Range(leftBorder, rightBorder), 7.5f), transform.rotation);
    }
}
