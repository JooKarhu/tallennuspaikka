using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour 
{
    public Text coinsHUD;
    public Text timer;

    void Update()
    {
        if (coinsHUD != null && timer != null)
        {
            coinsHUD.text = "Coins: " + Controller.coins.ToString() + "/" + Controller.maxCoins.ToString();
            timer.text = "Time left: " + Controller.seconds.ToString();
        }
    }
}