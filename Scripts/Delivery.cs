using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{

    // tut How To Use GetComponent    
    // ref https://docs.unity3d.com/ScriptReference/Collider2D.OnTriggerEnter2D.html
    // ref https://docs.unity3d.com/ScriptReference/Color32-ctor.html
    // ref https://docs.unity3d.com/ScriptReference/SpriteRenderer.html

    [SerializeField] Color32 hasPackageColor = new Color32(222, 30, 76, 255);
    [SerializeField] Color32 noPackageColor = new Color32(8, 146, 208, 255);  


    // set something to check whether it is true or false
    [SerializeField] float destroyDelay = 0.01f;
    bool hasPackage; 

    // variables
    SpriteRenderer spriteRenderer; 
    
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        // placeholder
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // pick up package
        if (other.tag == "DeliveryPackage" && !hasPackage)
        {
            Debug.Log("Successfully picked up package"); 
            hasPackage = true; 
            spriteRenderer.color = hasPackageColor; 
            Destroy(other.gameObject, destroyDelay); 
        }
        
        // deliver package
        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Successfully delivered package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            Destroy(other.gameObject, destroyDelay); 
        }
    
    }

}
