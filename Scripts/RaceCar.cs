using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCar : MonoBehaviour
{ 
    [SerializeField] float steerSpeed = 250f;
    [SerializeField] float moveSpeed = 10f;

     void Update()
    {
        // tut Using Time.deltaTime() 
        // changed script to add in a generalized Time.deltaTime 
        // played with values until car was responsive again

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime; 
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        // negative steerAmount to correct direction
        transform.Rotate(0, 0, -steerAmount); 


        transform.Translate(0, moveAmount, 0);
    }
}

