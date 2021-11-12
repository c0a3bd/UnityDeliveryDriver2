using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    // tut   Using OnTriggerEnter2D() 
    // ref https://docs.unity3d.com/ScriptReference/Collider2D.OnTriggerEnter2D.html

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Successful collision");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Successful trigger collision");
    }

}
