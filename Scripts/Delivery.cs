using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    // tut How To Use Bools  
    // ref https://docs.unity3d.com/ScriptReference/Collider2D.OnTriggerEnter2D.html
    // ref https://docs.unity3d.com/ScriptReference/GameObject-tag.html 
    // ref https://docs.unity3d.com/ScriptReference/Object-operator_Object.html


    // set something to check whether it is true or false
    bool hasPackage; 

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
            hasPackage = true; 
        }
        
        // deliver package
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Successfully delivered package");
            hasPackage = false;
        }

    }

}
