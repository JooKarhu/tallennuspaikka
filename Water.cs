using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour 
{
    public Transform spawn;

    void OnTriggerEnter(Collider col)
    {
        col.transform.position = spawn.transform.position;
        Controller.seconds -= 10;
    }
}