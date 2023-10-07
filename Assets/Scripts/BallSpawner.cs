using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject[] ballPrefab;
    float spawnRangeX = 4.0f;
    float spawnPosZ = 8.0f;
    float spawnPozY = 4.0f;
    float spawnPozY2=2.0f;
    float startDelay = 1.5f;
    float spawnInterval = 2.0f;
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    
    void Update()
    {
         
    }
    void SpawnRandomBall()
    {
        Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-spawnRangeX, spawnRangeX),UnityEngine.Random.Range(spawnPozY2,spawnPozY), spawnPosZ);
        int ballIndex = UnityEngine.Random.Range(0, ballPrefab.Length);
        Instantiate(ballPrefab[ballIndex], spawnPos, ballPrefab[ballIndex].transform.rotation);
    }
}
