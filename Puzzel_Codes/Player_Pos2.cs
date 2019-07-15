using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Pos2 : MonoBehaviour
{
    public Vector3 spawnPoint;


    private void Awake()
    {
        GameObject.FindGameObjectWithTag("Player").transform.position = spawnPoint;

    }
}
