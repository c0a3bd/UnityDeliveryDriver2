using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCar : MonoBehaviour
{ 
    [SerializeField] float steerSpeed = 0.5f;
    [SerializeField] float moveSpeed = 0.01f;

     void Update()
    {
        // tut Using Input.GetAxis()
        // removed hard coded values and accepting input from player keyboard

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed; 
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed;

        // negative steerAmount to correct direction
        transform.Rotate(0, 0, -steerAmount); 


        transform.Translate(0, moveAmount, 0);
    }
}

