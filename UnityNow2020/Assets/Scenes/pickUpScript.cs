﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpScript : MonoBehaviour
{
    public string pickupName;
    public string pickupType;
    public int pointsToAdd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.AddPoints(score);
            Destroy(gameObject);
        }
    }
}
