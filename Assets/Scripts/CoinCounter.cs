using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instanse;

    public TMP_Text coinText;
    public int currentCoins;

    void Awake()
    {
        instanse=this;
    }
   
    void Start()
    {
        coinText.text="Score: "+currentCoins.ToString();
    }


   public void IncreaseCions( int v)
    {
        currentCoins+=v;
        coinText.text="Score: "+currentCoins.ToString();
    }
}
