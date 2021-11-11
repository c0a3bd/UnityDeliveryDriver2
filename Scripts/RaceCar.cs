using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceCar : MonoBehaviour
{
     void Update()
    {
        transform.Rotate(0, 0, 0.1f);   
        
        // my successful attempt to move my car using only docs
        // transform.Translate(0, Time.deltaTime, 0);

        // as recommended in the tut
        transform.Translate(0, 0.01f, 0);
    }
}

