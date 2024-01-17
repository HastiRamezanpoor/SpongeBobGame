using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;
using System.Linq;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    
   public TMP_Text scoretext;
   public void Setup(int score)
   {
    gameObject.SetActive(true);
    CoinCounter.instanse.IncreaseCions(score);
    scoretext.text=score.ToString()+"Score: ";
   }
   public void Restart()
    {
        
        SceneManager.LoadScene(1);
    }
    public void MainMenu()
    {
        
        SceneManager.LoadScene(0);
    }

}
