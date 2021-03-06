using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    // Tut Simple Follow Camera 
    // Ref https://docs.unity3d.com/ScriptReference/MonoBehaviour.LateUpdate.html

    [SerializeField] GameObject FollowObject;

    // The camera should be the same as the car's position

    void LateUpdate()
    {
        transform.position = FollowObject.transform.position + new Vector3(0, 0, -10);
    }
}
