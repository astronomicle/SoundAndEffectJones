using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScirpt;

    void Start()
    {
        playerControllerScirpt = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnRandomObstacle", startDelay, repeatRate);
    }

    void Update()
    {
        
    }

    void SpawnRandomObstacle()
    {
        if (playerControllerScirpt.gameOver == false)
        {
            int obstacleIndex = Random.Range(0, obstaclePrefab.Length);
            Vector3 SpawnManager = spawnPos;
            Instantiate(obstaclePrefab[obstacleIndex], spawnPos, obstaclePrefab[obstacleIndex].transform.rotation);
        }
    }
}
