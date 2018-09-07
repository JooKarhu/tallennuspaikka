using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    void Start()
    {
        Controller.maxCoins++;
    }

    void Update()
    {
        transform.Rotate(Vector3.right * 128 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider col)
    {
        OnDestroy();
        Controller.coins ++;
    }

    void OnDestroy()
    {
        Destroy(this.gameObject);
    }
}