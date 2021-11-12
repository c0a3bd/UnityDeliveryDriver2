using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    // tut If Statements & Tags 
    // ref https://docs.unity3d.com/ScriptReference/Collider2D.OnTriggerEnter2D.html
    // ref https://docs.unity3d.com/ScriptReference/GameObject-tag.html 

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Successful collision");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // pick up package
        if (other.tag == "DeliveryPackage")
        {
            Debug.Log("Successfully picked up package"); 
        }
        
        // deliver package
        if (other.tag == "Customer")
        {
            Debug.Log("Successfully delivered package");
        }

    }

}
