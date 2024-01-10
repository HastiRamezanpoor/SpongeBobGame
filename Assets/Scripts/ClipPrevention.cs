using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipPrevention : MonoBehaviour
{
    public GameObject ClipProjector;
    public float checkDistance;
    public Vector3 newDirection;


    float lerpPos;
    RaycastHit hit;
    void Update()
    {
       if(Physics.Raycast(ClipProjector.transform.position,ClipProjector.transform.forward,out hit, checkDistance))
       {
        
            lerpPos=1 -(hit.distance / checkDistance);

       }
       else
       {
        lerpPos=0;

       }
       Mathf.Clamp01(lerpPos);
       transform.localRotation=
       Quaternion.Lerp(
        Quaternion.Euler(Vector3.zero),
        Quaternion.Euler(newDirection),
        lerpPos);
    
    
       
    }
    }

