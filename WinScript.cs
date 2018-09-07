using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScript : MonoBehaviour 
{
    public Text winText;

    void Awake()
    {
        winText.enabled = false;
    }

    void Update()
    {
        if (Controller.coins <= 0)
        {
            winText.enabled = true;
        }
    }
}
