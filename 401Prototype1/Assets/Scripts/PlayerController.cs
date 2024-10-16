﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
		 * (Kaiser Stanford)
		 * (PlayerMovement)
		 * (Prototype1)
		 * (Move the car)
		 */
public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public float forwardInput;
    public float horizontalInput;
    
    

    // Update is called once per frame
    void Update()
    {
        forwardInput =  Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Move Forward with input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
