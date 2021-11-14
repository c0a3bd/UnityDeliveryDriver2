using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCar : MonoBehaviour
{ 
    [SerializeField] float steerSpeed = 2f;
    [SerializeField] float moveSpeed = 2f;

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

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Successful collision");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
    
        moveSpeed = moveSpeed * -1; 
    }

}
