using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public float range=100f;
    public GameObject shotOrigin;
    public AudioSource shootSound;
 
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            shootSound.Play();
    
        }

    }
    void Shoot(){
        RaycastHit hit;
        if(Physics.Raycast(shotOrigin.transform.position,shotOrigin.transform.forward,out hit,range))
        {
            Debug.DrawLine(shotOrigin.transform.position,hit.point,Color.red,10f);
        }
    }
}
