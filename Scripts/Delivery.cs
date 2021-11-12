using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    // tut How To Destroy Objects   
    // ref https://docs.unity3d.com/ScriptReference/Collider2D.OnTriggerEnter2D.html
    // ref https://docs.unity3d.com/ScriptReference/Object.Destroy.html


    // set something to check whether it is true or false
    [SerializeField] float destroyDelay = 0.1f;
    bool hasPackage; 

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Successful collision");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // pick up package
        if (other.tag == "DeliveryPackage" && !hasPackage)
        {
            Debug.Log("Successfully picked up package"); 
            hasPackage = true; 
            Destroy(other.gameObject, destroyDelay); 
        }
        
        // deliver package
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Successfully delivered package");
            hasPackage = false;
        }

    }

}
