using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource collectedSound;
    public int value;
   
    void Start()
    {
        
    }
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            collectedSound.Play();
           Destroy(gameObject);
           CoinCounter.instanse.IncreaseCions(value);

             
        }
}
}