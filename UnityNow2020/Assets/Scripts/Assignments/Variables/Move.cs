﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public float verticleInput;
    public float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticleInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
       transform.Translate(Vector3.forward*speed*Time.deltaTime*verticleInput);
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        //(x,y,z)
        
    }
    /*
    //Detect collision with another object
     void OnCollisionEnter(Collision other)
    {
        Debug.Log("Colliding with an object");

        if (other.gameObject.CompareTag("Floor")) //Primary
        {
            Debug.Log("Colliding with Floor");
        }
        else if (other.gameObject.CompareTag("Obstacle")) //Secondary
        {
            Debug.Log("Colliding with Obstacle");
        }
        else //Default
        {
            Debug.Log("...");
        }
     


    }
    /*
    private void OnTriggerEnter(Collider other)
    {
     Debug.Log("You have entered the trigger!")   
    }
    */




}
