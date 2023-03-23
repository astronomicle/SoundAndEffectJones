using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 SpawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScirpt;

    void Start()
    {
        playerControllerScirpt = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScirpt.gameOver == false)
        {
            Instantiate(obstaclePrefab, SpawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
