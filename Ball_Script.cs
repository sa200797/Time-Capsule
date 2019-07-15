using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Script : MonoBehaviour
{
    public Vector3 lastpoint;

  

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Player").transform.position = lastpoint;
        }
    }
}
