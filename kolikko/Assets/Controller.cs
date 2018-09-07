using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour 
{
    public static int coins = 0;
    public static int maxCoins = 0;

    public static int seconds = 60;

    void Start()
    {
        InvokeRepeating("DecrementTime", 1, 1);
    }

    void Update()
    {
        if (seconds <= 0)
        {
            //Game Over
        }
    }

    void DecrementTime()
    {
        seconds--;
    }
}