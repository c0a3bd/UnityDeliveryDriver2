using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    // tut   Using OnCollisionEnter2D() 
    // ref https://docs.unity3d.com/ScriptReference/Collider.OnCollisionEnter.html

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("successful collision");
    }

}
