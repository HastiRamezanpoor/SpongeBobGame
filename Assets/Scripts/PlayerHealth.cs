using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    private float health;
    private float lerpTimer;
    public float maxHealth=100f;
    public float chipSpeed=2f;
    public Image frontHealthBar;
    public Image backHealthBar;
    public AudioSource hurtSound;
    public GameObject back;


    void Start()
    {
        health=maxHealth;
    }

      void OnTriggerEnter(Collider other)
    {
         health=Mathf.Clamp(health,0,maxHealth);
        UpdateHealthUI();
       
        if(other.gameObject.tag=="EvilCube")
        {
             TakeDamage(Random.Range(5,10));
              hurtSound.Play();
             
        }
        
        }

    public void UpdateHealthUI(){
        Debug.Log(health);
        float fillF=frontHealthBar.fillAmount;
        float fillB=backHealthBar.fillAmount;
        float hFraction=health/maxHealth;
        if(fillB>hFraction)
        {
            frontHealthBar.fillAmount=hFraction;
            backHealthBar.color=Color.red;
            lerpTimer+=Time.deltaTime;
            float percentComplete=lerpTimer/chipSpeed;
            backHealthBar.fillAmount=Mathf.Lerp(fillB,hFraction,percentComplete);
        }

    }
    public void TakeDamage(float damage)
    {
        health-=damage;
        lerpTimer=0f;
         if(health<=0f)
        {
            GameOver();

        }
    }
     void GameOver()
        {
            
            SceneManager.LoadScene(2);
            
        }
    

}