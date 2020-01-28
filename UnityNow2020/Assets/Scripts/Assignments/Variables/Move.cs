﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(0,0,.05f);
        
    }

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

    private void OnTriggerEnter(Collider other)
    {
     Debug.Log("You have entered the trigger!")   
    }





}
