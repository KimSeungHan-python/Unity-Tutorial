using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class PlayerController : MonoBehaviour
{

    public float speed = 5.0f;
    public float turnSpeed;

    public float horizontalInput;
    public float forwardInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move the Vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);//직선보면서 좌우 움직임
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);//회전하면서 좌우 움직임 자연스러운 움직임
    }
}
