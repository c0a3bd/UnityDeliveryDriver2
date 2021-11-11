using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCar : MonoBehaviour
{ 
    // added SerializeField to the variables which allows us to modify these variables
    // from within Unity's inspector

    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.01f;

     void Update()
    {
        transform.Rotate(0, 0, steerSpeed);   
        
        // my successful attempt to move my car using only docs
        // transform.Translate(0, Time.deltaTime, 0);

        // as recommended in the tut
        transform.Translate(0, moveSpeed, 0);
    }
}

