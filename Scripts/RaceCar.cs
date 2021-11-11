using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCar : MonoBehaviour
{
    // declare and initialize variables then use the variables below
    // vs hard coding the values making the script more dynamic
    
    float steerSpeed = 0.1f;
    float moveSpeed = 0.01f;


     void Update()
    {
        transform.Rotate(0, 0, steerSpeed);   
        
        // my successful attempt to move my car using only docs
        // transform.Translate(0, Time.deltaTime, 0);

        // as recommended in the tut
        transform.Translate(0, moveSpeed, 0);
    }
}

