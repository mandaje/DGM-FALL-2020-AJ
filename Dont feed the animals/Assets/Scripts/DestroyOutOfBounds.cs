﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;

    // Update is called once per frame
    void Update()
    {
        // Destroy any object entering the topbounds
        if(transform.position.z > topBounds){
            Destroy(gameObject);
        }
        // Destroy any object entering the lowerbound
        else if(transform.position.z < lowerBounds)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }
}
