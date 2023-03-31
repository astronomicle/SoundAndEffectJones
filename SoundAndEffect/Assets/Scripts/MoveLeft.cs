using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 20;
    private PlayerController playerControllerScript;
    private float leftBound = -15;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }       

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            playerControllerScript.score += 1;
            Debug.Log(playerControllerScript.score + " pts");
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            speed = 30;
        }
        else
        {
            speed = 20;
        }
    }
}
