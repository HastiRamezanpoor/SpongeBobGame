using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

      public float damage=10;
    public float range=100f;
     public Camera fbsCam;
     public AudioSource shootSound;
     public GameObject muzzleEffect;
     public GameObject BloodEffect;
    


private void Start()
{
   

}

     void Update(){
       
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            shootSound.Play();
        }


     }

     void Shoot()
     {
       
        muzzleEffect.GetComponent<ParticleSystem>().Play();
       
        RaycastHit hit;
        if(Physics.Raycast(fbsCam.transform.position,fbsCam.transform.forward,out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target=hit.transform.GetComponent<Target>();
            if(target!=null)
            {
                target.TakeDamage(damage);
                Instantiate(BloodEffect,hit.point,Quaternion.identity);
               
              

            }
        }
      
        
     }



}
