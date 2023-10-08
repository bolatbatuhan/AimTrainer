using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject[] ballPrefab;
    float spawnRangeX = 4.0f;
    float spawnPosZ = 8.0f;

    float spawnRangeYUp = 4.0f;
    float spawnRangeYLower = 2.0f;

    float startDelay = 1.5f;
    float spawnInterval = 1.0f;

    float ballLifeTime = 0.5f;


    private void Start()
    {
        InvokeRepeating("randomBallSpawner", startDelay, spawnInterval);
    }

    private void randomBallSpawner()
    {
        Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-spawnRangeX, spawnRangeX), UnityEngine.Random.Range(spawnRangeYLower, spawnRangeYUp), spawnPosZ);
        int ballIndex = UnityEngine.Random.Range(0, ballPrefab.Length);
        GameObject newBall = Instantiate(ballPrefab[ballIndex], spawnPos, ballPrefab[ballIndex].transform.rotation);

        Destroy(newBall, ballLifeTime);

    }
}

