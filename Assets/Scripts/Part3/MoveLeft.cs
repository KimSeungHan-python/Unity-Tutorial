using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MoveLeft : MonoBehaviour
{
    private float speed = 15.0f;    
    private PlayerController3 playerControllerScript;
    
    private float leftBound = -15;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController3>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
